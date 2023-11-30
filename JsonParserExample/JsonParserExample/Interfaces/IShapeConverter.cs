using Newtonsoft.Json.Linq;

namespace JsonParserExample.Interfaces
{
    internal interface IShapeConverter
    {
        Type GetShapeType(JToken json);
    }
}
