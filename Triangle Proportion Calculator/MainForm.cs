using System;
using System.Windows.Forms;
using Triangle_Proportion_Calculator.Initialize;

namespace Triangle_Proportion_Calculator
{
    public partial class TPC : Form
    {
        public TPC()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int Completion = 0;
            int SideToCalculate = 0;
            int SidesCalculated = 0;
            OutputBox.Text = "";

            bool SideCVisible = SideCInput.Visible;

            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    if (c.Visible)
                    {
                        string TextName = c.Text;
                        string ControlName = c.Name;

                    if (TextName == "N" || TextName == "n")
                        {

                            Initialization.Init_SideToCalculate(ControlName, SideCVisible, ref SideToCalculate, ref Completion, ref SidesCalculated);

                            if (SideCVisible == false && Completion == 99)
                            {
                                OutputBox.AppendText("There is more than 1 variable entered. There needs to be only 1 N for this proportion." + Environment.NewLine);
                                return;

                            }
                            else if (SideCVisible == true && Completion == 99)
                            {
                                OutputBox.AppendText("There is more than 2 variable entered. There needs to be only 1 N for this proportion." + Environment.NewLine);
                                return;

                            }

                        }

                        else
                        {
                            OutputBox.AppendText(ControlName + " is in the incorrect format." + Environment.NewLine);

                        }

                    }

                }

            }

            Triangle Triangle1 = new Triangle();
            Triangle Triangle2 = new Triangle();

            if (SideToCalculate >= 1 && SideToCalculate <= 6 && Completion != 99)
            {

                string SideAIn = SideAInput.Text;
                string SideBIn = SideBInput.Text;
                string SideCIn = SideCInput.Text;
                string SideXIn = SideXInput.Text;
                string SideYIn = SideYInput.Text;
                string SideZIn = SideZInput.Text;
                bool Successful = false;

                Initialization.Init_SetTriangle(SideToCalculate, Triangle1, Triangle2, SideAIn, SideBIn, SideCIn, SideXIn, SideYIn, SideZIn, SideCVisible, ref Completion);

                if (Completion == 99)
                {
                    OutputBox.AppendText("There is a zero on one of the sides. Variable will be zero.");
                    return;

                }

                if (SideToCalculate <= 3)
                {
                    DoMath.DoMath_Triangle1Calculation(Triangle1, Triangle2, ref Successful);

                    if (Successful == true)
                    {
                        OutputBox.AppendText("Triangle1 calculation is follows: " + Environment.NewLine +
                                                "Side A: " + Triangle1.SideA + Environment.NewLine +
                                                "Side B: " + Triangle1.SideB + Environment.NewLine);

                        if (SideCVisible == true)
                        {
                            OutputBox.AppendText("Side C: " + Triangle1.SideC + Environment.NewLine);

                        }

                    }

                }

                else if (SideToCalculate > 3 && SideToCalculate <= 6)
                {
                    DoMath.DoMath_Triangle2Calculation(Triangle1, Triangle2, ref Successful);

                    if (Successful == true)
                    {
                        OutputBox.AppendText("Triangle2 calculation is follows: " + Environment.NewLine +
                                                "Side A: " + Triangle2.SideA + Environment.NewLine +
                                                "Side B: " + Triangle2.SideB + Environment.NewLine);

                        if (SideCVisible == true)
                        {
                            OutputBox.AppendText("Side C: " + Triangle2.SideC + Environment.NewLine);

                        }

                    }

                }

            }

        }

        private void TwoThreePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TwoThreePicker.SelectedIndex == 1)
            {
                ThreeLabel.Visible = true;
                SideCInput.Visible = true;
                SideZInput.Visible = true;

            }

            else
            {
                ThreeLabel.Visible = false;
                SideCInput.Visible = false;
                SideZInput.Visible = false;

                SideCInput.Text = "";
                SideZInput.Text = "";

            }

        }
    }
}
