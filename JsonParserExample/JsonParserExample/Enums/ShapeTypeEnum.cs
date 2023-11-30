using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JsonParserExample.Enum
{
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum ShapeTypeEnum
    {
        Circle,
        Rectangle,
        Ellipse
    }
}
