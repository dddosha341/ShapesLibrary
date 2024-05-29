namespace ShapesLibrary
{
    public class Triangle : Shape
    {
        #region Constructors
        public Triangle() : base()
        {
            
        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            double[] sides = new double[] { sideA, sideB, sideC };

            this.Sides = sides;
        }

        public Triangle(IEnumerable<double> sides) : base(sides) 
        {

        }
        #endregion


        #region Methods
        public override double Area()
        {
            double[] sides = this.Sides.ToArray();

            double halfPerimeter = sides.Sum(s => s / 2);

            return Math.Sqrt(halfPerimeter * 
                (halfPerimeter - sides[0]) *
                (halfPerimeter - sides[1]) *
                (halfPerimeter - sides[2]));
        }
        #endregion
    }
}
