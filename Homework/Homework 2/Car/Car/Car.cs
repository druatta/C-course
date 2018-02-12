using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Car
    {
        #region Fields
        private float miles;
        private float gallons;
        private float Zero = 0;
        private float twentyFive = 25;
        #endregion

        #region Properties
        public float Miles
        {
            get
            {
                return miles;
            }

            set
            {

            }
        }

        public float Gallons
        {
            get
            {
                return gallons;
            }

            set
            {
                if (value < Zero)
                {
                    throw new ArgumentOutOfRangeException();
                }
            
                else if (value > twentyFive)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    gallons = value;
                }
            }
        }

        #endregion

        #region Constructors

        public Car()
        {

        }

        #endregion

        public static void Main()
        {

        }
    }
}
