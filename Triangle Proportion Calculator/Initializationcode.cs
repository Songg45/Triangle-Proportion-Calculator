using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Proportion_Calculator.Initialize
{
    public class Initialization
    {
        internal static void Init_SideToCalculate(string ControlName, ref int SideToCalculate, ref int Completion)
        {
            switch (ControlName)
            {

                case "SideAInput":
                    SideToCalculate = 1;
                    break;

                case "SideBInput":
                    SideToCalculate = 2;
                    break;

                case "SideCInput":
                    SideToCalculate = 3;
                    break;

                case "SideXInput":
                    SideToCalculate = 4;
                    break;

                case "SideYInput":
                    SideToCalculate = 5;
                    break;

                case "SideZInput":
                    SideToCalculate = 6;
                    break;

                default:
                    Completion = 99;
                    break;

            }
                return;
        }

        internal static void Init_SetTriangle(int SideToCalculate, Triangle Triangle1, Triangle Triangle2, string SideAIn, string SideBIn, string SideCIn,
                                                                                                            string SideXIn, string SideYIn, string SideZIn, bool SideCVisible)
        {

            switch (SideToCalculate)
            {

                case 1:
                    Triangle1.SideB = float.Parse(SideBIn);
                    Triangle2.SideA = float.Parse(SideXIn);
                    Triangle2.SideB = float.Parse(SideYIn);

                    Triangle1.SideToCompare = 1;
                    Triangle2.SideToCompare = 0;
                    break;

                case 2:
                    Triangle1.SideA = float.Parse(SideAIn);
                    Triangle2.SideA = float.Parse(SideXIn);
                    Triangle2.SideB = float.Parse(SideYIn);

                    Triangle1.SideToCompare = 2;
                    Triangle2.SideToCompare = 0;
                    break;

                case 3:
                    if (SideCVisible)
                    {

                        Triangle1.SideA = float.Parse(SideAIn);
                        Triangle1.SideB = float.Parse(SideBIn);
                        Triangle2.SideA = float.Parse(SideXIn);
                        Triangle2.SideB = float.Parse(SideYIn);
                        Triangle2.SideC = float.Parse(SideZIn);
                        Triangle1.SideToCompare = 3;
                        Triangle2.SideToCompare = 0;

                    }
                    break;

                case 4:
                    Triangle1.SideA = float.Parse(SideAIn);
                    Triangle1.SideB = float.Parse(SideBIn);
                    Triangle2.SideB = float.Parse(SideYIn);

                    Triangle1.SideToCompare = 0;
                    Triangle2.SideToCompare = 1;
                    break;

                case 5:
                    Triangle1.SideA = float.Parse(SideAIn);
                    Triangle1.SideB = float.Parse(SideBIn);
                    Triangle2.SideA = float.Parse(SideXIn);

                    Triangle1.SideToCompare = 0;
                    Triangle2.SideToCompare = 2;
                    break;

                case 6:
                    if (SideCVisible)
                    {

                        Triangle1.SideA = float.Parse(SideAIn);
                        Triangle1.SideB = float.Parse(SideBIn);
                        Triangle1.SideC = float.Parse(SideCIn);
                        Triangle2.SideA = float.Parse(SideXIn);
                        Triangle2.SideB = float.Parse(SideZIn);

                        Triangle1.SideToCompare = 0;
                        Triangle2.SideToCompare = 3;

                    }
                    break;

            }

        }

    }
}
