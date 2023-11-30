using JsonParserExample.Enum;
using JsonParserExample.Interfaces;

namespace JsonParserExample.Shapes
{
    public class ShapeJsonConverter : JsonParserConverter<IShapeType, ShapeTypeEnum>
    {
        public ShapeJsonConverter()
        {
            typeMapping[ShapeTypeEnum.Circle] = typeof(Circle);
            typeMapping[ShapeTypeEnum.Rectangle] = typeof(Rectangle);
            typeMapping[ShapeTypeEnum.Ellipse] = typeof(Ellipse);
        }
    }
}
