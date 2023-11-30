using JsonParserExample.Enum;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace JsonParserExample.Shapes
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Circle : Shape
    {
        public ShapeTypeEnum Type => ShapeTypeEnum.Circle;
        public int Radius { get; set; }
    }

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Ellipse : Shape
    {
        public ShapeTypeEnum Type => ShapeTypeEnum.Ellipse;
        public int Radius { get; set; }
        public int Radius_A { get; set; }   
        public List<string> Cocos { get; set; }
    }
}
