using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ShapesLibrary
{
    public abstract class Shape : IShape
    {
        #region Fields
        private double[] _sides;

        private bool _isCircle;
        #endregion


        #region Properties

        public IEnumerable<double> Sides
        {
            get { return _sides; }

            set
            {
                foreach (var side in value)
                {
                    if (side <= 0) 
                        throw new ArgumentException("Side value can`t be zero or negative");
                }

                if(value.Count() == 1)
                    this._isCircle = true;
                else if (value.Count() < 3)
                    throw new ArgumentException("Min count of sides is 3");
                _sides = value.ToArray();
            }
        }
        #endregion


        #region Constructors
        public Shape()
        {

        }

        public Shape(IEnumerable<double> sides)
        {
            this.Sides = sides;
        }

        public Shape(double radius)
        {
            this._sides = new double[] { radius };
            this._isCircle= true;
        }
        #endregion


        #region Methods

        public abstract double Area();

        #endregion
    }
}
