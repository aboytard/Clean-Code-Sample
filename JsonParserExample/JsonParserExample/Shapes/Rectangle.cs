using JsonParserExample.Enum;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace JsonParserExample.Shapes
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Rectangle : Shape
    {
        public ShapeTypeEnum Type => ShapeTypeEnum.Rectangle;
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
