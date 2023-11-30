namespace SOLID.LiskovSubsitution
{
    //There is a special case for Square class. We made some special changes when setting values.  
    //We need refactoring this classes

    //Classic Problem : Is A Square A Rectangle?
    public class Rectangle
    {
        protected int _width;
        protected int _height;

        public virtual int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public virtual int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Area => _width * _height;
    }

    public class Square : Rectangle
    {
        public override int Height
        {
            get
            {
                return _height;
            }
            set
            {
                //Important
                _width = value;
                _height = value;
            }
        }

        public override int Width
        {
            get
            {
                return _width;
            }
            set
            {
                //Important
                _width = value;
                _height = value;
            }
        }
    }
}
