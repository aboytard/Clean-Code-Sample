using JsonParserExample;
using JsonParserExample.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


var circle = new Circle() { Radius = 1 };
var testCircle = new TestObject() { Shape = circle };
var testCircleJson = JObject.FromObject(testCircle).ToString();
var circleAfterReconversion = JsonConvert.DeserializeObject<TestObject>(testCircleJson);
if (circleAfterReconversion.Shape is Circle circleShape)
{
    Console.WriteLine($"Circle: Radius = {circleShape.Radius}");
}

var rectangle = new Rectangle() { Height = 1, Width = 2 };
var testRectangle = new TestObject() { Shape = rectangle };
var testRectangleJson = JObject.FromObject(testRectangle).ToString();
var rectangleAfterReconversion = JsonConvert.DeserializeObject<TestObject>(testRectangleJson);
if (rectangleAfterReconversion.Shape is Rectangle rectangleShape)
{
    Console.WriteLine($"Rectangle: Width = {rectangleShape.Width}, Height = {rectangleShape.Height}");
}


var ellipse = new Ellipse() { Radius = 1, Radius_A = 2, Cocos = new List<string>(){"true", "true"}};
var testEllipse = new TestObject() { Shape = ellipse };
var testEllipseJson = JObject.FromObject(testEllipse).ToString();
var testEllipseJsonAfterReconversion = JsonConvert.DeserializeObject<TestObject>(testEllipseJson);

if (testEllipseJsonAfterReconversion.Shape is Ellipse ellipseShape)
{
    Console.WriteLine($"Rectangle: Radius = {ellipseShape.Radius}, Radius_A = {ellipseShape.Radius_A}, Cocos={ellipseShape.Cocos}");
}
Console.ReadLine();