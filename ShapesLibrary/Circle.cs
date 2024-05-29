namespace ShapesLibrary
{
    public class Circle : Shape
    {
        #region Fields

        private double _radius;

        #endregion

        #region Properties

        public double Radius
        {
            get { return _radius; }

            set 
            {
                if (_radius <= 0)
                    throw new ArgumentException("Radius can`t be zero or negative");

                _radius = value;
                Sides = new double[] { _radius };
            }
        }

        #endregion

        #region Constuctors
        public Circle() : base() { }

        public Circle(double radius) : base(radius) 
        { 

        }
        #endregion

        #region Methods
        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }
        #endregion
    }
}
