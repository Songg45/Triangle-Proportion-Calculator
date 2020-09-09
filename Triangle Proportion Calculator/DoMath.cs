using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Proportion_Calculator
{
    class DoMath
    {

        public static void DoMath_Triangle1Calculation(Triangle Triangle1, Triangle Triangle2)
        {

           int UnknownSide = Triangle1.SideToCompare;
           float CalculatedSide = 0;

            switch (UnknownSide)
            {
                case 1:
                    CalculatedSide = Triangle2.SideA * Triangle1.SideB;
                    CalculatedSide = CalculatedSide / Triangle2.SideB;

                    Triangle1.SideA = CalculatedSide;
                    break;

                case 2:
                    CalculatedSide = Triangle1.SideA * Triangle2.SideB;
                    CalculatedSide = CalculatedSide / Triangle2.SideA;

                    Triangle1.SideB = CalculatedSide;
                    break;

                case 3:
                    break;


                default:
                    break;
            }

        }

    }
}
