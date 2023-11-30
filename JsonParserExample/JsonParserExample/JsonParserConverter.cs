using JsonParserExample.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonParserExample
{
    public class JsonParserConverter<T, S> : JsonConverter<T>, IShapeConverter
        where T : class
    {
        protected Dictionary<S, Type> typeMapping;

        public override bool CanRead => true;

        public override bool CanWrite => false;

        public virtual string typePropertyName => "type";

        public JsonParserConverter()
        {
            typeMapping = new();
        }

        public Type GetShapeType(JToken json)
        {
            var typeToken = json[typePropertyName];
            if (typeToken == null)
                throw new ArgumentException("No type.");
            var typeTokenObject = typeToken.ToObject<S>();
            if (!typeMapping.ContainsKey(typeTokenObject))
                throw new ArgumentException($"Unknown type '{typeTokenObject}'.");
            return typeMapping[typeTokenObject];
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var mainToken = JToken.ReadFrom(reader);
            if (!mainToken.HasValues)
            {
                return null;
            }
            var typeToken = mainToken[typePropertyName];
            if (typeToken == null)
            {
                var typeObject = mainToken.ToObject<T>(serializer);
                return typeObject;
            }
            var typeTokenObject = typeToken.ToObject<S>();
            if (!typeMapping.ContainsKey(typeTokenObject))
            {
                throw new ArgumentException($"Unknown type '{typeTokenObject}'.");
            }
            var configType = typeMapping[typeTokenObject];

            return (T)mainToken.ToObject(configType, serializer);
        }

        public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
