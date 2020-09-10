using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Proportion_Calculator
{
    class DoMath
    {

        public static void DoMath_Triangle1Calculation(Triangle Triangle1, Triangle Triangle2, ref bool Successful)
        {

           int UnknownSide = Triangle1.SideToCompare;
           float CalculatedSide;

            switch (UnknownSide)
            {
                case 1:
                    CalculatedSide = Triangle1.SideB * Triangle2.SideA;
                    CalculatedSide /= Triangle2.SideB;

                    Triangle1.SideA = CalculatedSide;
                    Successful = true;
                    break;

                case 2:
                    CalculatedSide = Triangle1.SideA * Triangle2.SideB;
                    CalculatedSide /= Triangle2.SideA;

                    Triangle1.SideB = CalculatedSide;
                    Successful = true;
                    break;

                case 3:
                    break;


                default:
                    break;
            }

        }

        public static void DoMath_Triangle2Calculation(Triangle Triangle1, Triangle Triangle2, ref bool Successful)
        {
            int UnknownSide = Triangle2.SideToCompare;
            float CalculatedSide;

            switch (UnknownSide)
            {
                case 1:
                    CalculatedSide = Triangle2.SideB * Triangle1.SideA;
                    CalculatedSide /= Triangle1.SideB;

                    Triangle2.SideA = CalculatedSide;
                    Successful = true;
                    break;

                case 2:
                    CalculatedSide = Triangle2.SideA * Triangle1.SideB;
                    CalculatedSide /= Triangle1.SideA;

                    Triangle2.SideB = CalculatedSide;
                    Successful = true;
                    break;

                case 3:
                    break;


                default:
                    break;
            }



        }

    }
}
