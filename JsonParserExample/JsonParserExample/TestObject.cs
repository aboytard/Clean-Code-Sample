using JsonParserExample.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JsonParserExample
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class TestObject
    {
        [JsonProperty(Required = Required.Always)]
        [JsonConverter(typeof(ShapeJsonConverter))]
        public Shape Shape { get; set; }
    }
}
