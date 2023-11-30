namespace SOLID.LiskovSubsitution
{
    public abstract class NewShape
    {
        public abstract double CalculateArea();
    }

    public class NewRectangle : NewShape
    {
        public double Height { get; }
        public double Width { get; }

        public NewRectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }
    }

    public class NewSquare : NewShape
    {
        public int Side { get; }
        public NewSquare(int side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return this.Side * this.Side;
        }
    }
}
