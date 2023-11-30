using JsonParserExample.Enum;
using JsonParserExample.Interfaces;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace JsonParserExample.Shapes
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public abstract class Shape : IShapeType
    {
        ShapeTypeEnum IShapeType.Type => throw new NotImplementedException();
    }
}
