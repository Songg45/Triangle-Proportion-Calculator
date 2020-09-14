using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Proportion_Calculator
{
    class DoMath
    {

        public static void Triangle1Calculation(Triangle Triangle1, Triangle Triangle2, ref bool Successful)
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

                    if (Triangle1.SideA == 0 || Triangle2.SideA == 0)
                    {
                        CalculatedSide = Triangle1.SideC * Triangle2.SideB;
                        CalculatedSide /= Triangle2.SideC;

                        Triangle1.SideB = CalculatedSide;
                        Successful = true;
                        break;

                    }

                    else
                    {
                        CalculatedSide = Triangle1.SideA * Triangle2.SideB;
                        CalculatedSide /= Triangle2.SideA;

                        Triangle1.SideB = CalculatedSide;
                        Successful = true;
                        break;

                    }

                case 3:
                    CalculatedSide = Triangle1.SideB * Triangle2.SideC;
                    CalculatedSide /= Triangle2.SideB;

                    Triangle1.SideC = CalculatedSide;
                    Successful = true;
                    break;

                default:
                    break;
            }

        }

        public static void Triangle2Calculation(Triangle Triangle1, Triangle Triangle2, ref bool Successful)
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
                    if (Triangle2.SideA == 0 || Triangle1.SideA == 0)
                    {
                        CalculatedSide = Triangle2.SideC * Triangle1.SideB;
                        CalculatedSide /= Triangle1.SideC;

                        Triangle2.SideB = CalculatedSide;

                        Successful = true;
                        break;
                    }

                    else
                    {
                        CalculatedSide = Triangle2.SideA * Triangle1.SideB;
                        CalculatedSide /= Triangle1.SideA;

                        Triangle2.SideB = CalculatedSide;
                        Successful = true;
                        break;

                    }

                case 3:
                    CalculatedSide = Triangle2.SideB * Triangle1.SideC;
                    CalculatedSide /= Triangle1.SideB;

                    Triangle2.SideC = CalculatedSide;
                    Successful = true;
                    break;

                default:
                    break;
            }

        }

        public static void ThreeSideCalculation(Triangle Triangle1, Triangle Triangle2, ref bool Successful)
        {
            int Triangle1Calculation = 7 - Triangle1.SideToCompare;
            int Triangle2Calculation = 7 - Triangle2.SideToCompare;
            bool Triangle1Complete = false;
            bool Triangle2Complete = false;
            bool Done = false;

            if ((Triangle1Calculation == Triangle2Calculation) || (Triangle1Calculation == 3 && Triangle2Calculation == 6) || (Triangle1Calculation == 6 && Triangle2Calculation == 3))
            {
                Successful = false;
                return;

            }

            if (Triangle1Calculation == 0)
                Triangle1Complete = true;

            if (Triangle2Calculation == 0)
                Triangle2Complete = true;

            do
            {
                if ((Triangle1Calculation > Triangle2Calculation) && (Triangle2Calculation != 2))
                {

                    if (Triangle1Calculation == 6)
                    {
                        Triangle1.SideToCompare = 2;
                        DoMath.Triangle1Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle1Calculation = 4;

                        else
                            return;

                    }

                    if (Triangle1Calculation == 5)
                    {
                        Triangle1.SideToCompare = 3;
                        DoMath.Triangle1Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle1Calculation = 1;

                        else
                            return;

                    }

                    if (Triangle1Calculation == 4)
                    {
                        Triangle1.SideToCompare = 3;
                        DoMath.Triangle1Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle1Calculation = 0;

                        else
                            return;

                    }

                    if (Triangle1Calculation == 3)
                    {
                        Triangle1.SideToCompare = 2;
                        DoMath.Triangle1Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle1Calculation = 1;

                        else
                            return;

                    }
 
                    if (Triangle1Calculation == 2)
                    {
                        Triangle1.SideToCompare = 2;
                        DoMath.Triangle1Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle1Calculation = 0;

                        else
                            return;

                    }

                    if (Triangle1Calculation == 1)
                    {
                        Triangle1.SideToCompare = 1;
                        DoMath.Triangle1Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle1Calculation = 0;

                        else
                            return;

                    }

                    if (Triangle1Calculation == 0)
                        Triangle1Complete = true;

                }

                if ((Triangle2Calculation > Triangle1Calculation) || (Triangle2Calculation == 2))
                {

                    if (Triangle2Calculation == 6)
                    {
                        Triangle2.SideToCompare = 2;
                        DoMath.Triangle2Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle2Calculation = 4;

                        else
                            return;

                    }

                    if (Triangle2Calculation == 5)
                    {
                        Triangle2.SideToCompare = 3;
                        DoMath.Triangle2Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle2Calculation = 1;

                        else
                            return;

                    }

                    if (Triangle2Calculation == 4)
                    {
                        Triangle2.SideToCompare = 3;
                        DoMath.Triangle2Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle2Calculation = 0;

                        else
                            return;

                    }

                    if (Triangle2Calculation == 3)
                    {
                        Triangle2.SideToCompare = 2;
                        DoMath.Triangle2Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle2Calculation = 1;

                        else
                            return;

                    }

                    if (Triangle2Calculation == 2)
                    {
                        Triangle2.SideToCompare = 2;
                        DoMath.Triangle2Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle2Calculation = 0;

                        else
                            return;

                    }

                    if (Triangle2Calculation == 1)
                    {
                        Triangle2.SideToCompare = 1;
                        DoMath.Triangle2Calculation(Triangle1, Triangle2, ref Successful);

                        if (Successful == true)
                            Triangle2Calculation = 0;

                        else
                            return;

                    }

                    if (Triangle2Calculation == 0)
                        Triangle2Complete = true;

                }

                if (Triangle1Complete == true && Triangle2Complete == true)
                    Done = true;

            } while (Done == false);
        }
    }
}
