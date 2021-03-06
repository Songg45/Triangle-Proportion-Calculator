﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Proportion_Calculator.Initialize
{
    public class Initialization
    {
        internal static void Init_SideToCalculate(string ControlName, bool SideCVisible, ref int SideToCalculate, ref int Completion, ref int SidesCalculated)
        {

            if (SideCVisible == false && SidesCalculated >= 1)
            {

                Completion = 99;
                return;

            }
            else if (SideCVisible == true && SidesCalculated >= 2)
            {
                Completion = 99;
                return;

            }

            switch (ControlName)
            {

                case "SideAInput":
                    SideToCalculate += 1;
                    break;

                case "SideBInput":
                    SideToCalculate += 2;
                    break;

                case "SideCInput":
                    SideToCalculate += 3;
                    break;

                case "SideXInput":
                    SideToCalculate += 4;
                    break;

                case "SideYInput":
                    SideToCalculate += 5;
                    break;

                case "SideZInput":
                    SideToCalculate += 6;
                    break;

                default:
                    Completion = 99;
                    break;

            }

            SidesCalculated++;

            if (SideToCalculate > 6 || SidesCalculated == 2)
            {
                SideToCalculate = 7;

            }

            return;
        }

        internal static void Init_SetTriangle(int SideToCalculate, Triangle Triangle1, Triangle Triangle2, string SideAIn, string SideBIn, string SideCIn,
                                                                                                            string SideXIn, string SideYIn, string SideZIn, 
                                                                                                             bool SideCVisible, ref int Completion)
        {

            if (SideAIn == "0" || SideBIn == "0" || SideCIn == "0"|| SideXIn == "0" || SideYIn == "0" || SideZIn == "0")
            {
                Completion = 99;
                return;

            }

            switch (SideToCalculate)
            {
                case 1:
                    if (SideCVisible)
                    {
                        Triangle1.SideC = float.Parse(SideCIn);
                        Triangle2.SideC = float.Parse(SideZIn);

                    }

                    Triangle1.SideB = float.Parse(SideBIn);
                    Triangle2.SideA = float.Parse(SideXIn);
                    Triangle2.SideB = float.Parse(SideYIn);

                    Triangle1.SideToCompare = 1;
                    Triangle2.SideToCompare = 0;
                    break;

                case 2:
                    if (SideCVisible)
                    {
                        Triangle1.SideC = float.Parse(SideCIn);
                        Triangle2.SideC = float.Parse(SideZIn);

                    }

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
                    if (SideCVisible)
                    {
                        Triangle1.SideC = float.Parse(SideCIn);
                        Triangle2.SideC = float.Parse(SideZIn);

                    }

                    Triangle1.SideA = float.Parse(SideAIn);
                    Triangle1.SideB = float.Parse(SideBIn);
                    Triangle2.SideB = float.Parse(SideYIn);

                    Triangle1.SideToCompare = 0;
                    Triangle2.SideToCompare = 1;
                    break;

                case 5:
                    if (SideCVisible)
                    {
                        Triangle1.SideC = float.Parse(SideCIn);
                        Triangle2.SideC = float.Parse(SideZIn);

                    }

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
                        Triangle2.SideB = float.Parse(SideYIn);

                        Triangle1.SideToCompare = 0;
                        Triangle2.SideToCompare = 3;

                    }
                    break;

                case 7:

                    if ((SideAIn == "" && SideXIn == "") || (SideBIn == "" && SideYIn == "") || (SideCIn == "" && SideZIn == ""))
                    {
                        Completion = 99;
                        return;

                    }

                    if (float.TryParse(SideAIn, out _))
                    {
                        Triangle1.SideA = float.Parse(SideAIn);
                        Triangle1.SideToCompare += 1;

                    }

                    if (float.TryParse(SideBIn, out _))
                    {
                        Triangle1.SideB = float.Parse(SideBIn);
                        Triangle1.SideToCompare += 2;

                    }

                    if (float.TryParse(SideCIn, out _))
                    {
                        Triangle1.SideC = float.Parse(SideCIn);
                        Triangle1.SideToCompare += 4;

                    }

                    if (float.TryParse(SideXIn, out _))
                    {
                        Triangle2.SideA = float.Parse(SideXIn);
                        Triangle2.SideToCompare += 1;

                    }
                        
                    if (float.TryParse(SideYIn, out _))
                    {
                        Triangle2.SideB = float.Parse(SideYIn);
                        Triangle2.SideToCompare += 2;

                    }
                        
                    if (float.TryParse(SideZIn, out _))
                    {
                        Triangle2.SideC = float.Parse(SideZIn);
                        Triangle2.SideToCompare += 4;

                    }

                    break;

            }

        }

    }
}
