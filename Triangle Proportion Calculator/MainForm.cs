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

        private void Button1_Click(object sender, EventArgs e)
        {
            int Total = 0;
            int Completion = 0;
            int SideToCalculate = 0;
            float TextboxValue = 0;
            OutputBox.Text = "";

            foreach (Control c in Controls)
            {

                if (c is TextBox)
                {

                    if (c.Visible)
                    {
                        Total++;
                        string TextName = c.Text;
                        string ControlName = c.Name;

                        if (float.TryParse(c.Text, out TextboxValue))
                        {
                            Completion++;
                        }

                        else if (TextName == "N")
                        {
                             
                           Initialization.Init_SideToCalculate(ControlName, ref SideToCalculate, ref Completion);

                        }

                        else
                        {

                            OutputBox.AppendText(c.Name + " is in the incorrect format." + Environment.NewLine);

                        }

                    }

                }

            }

            Triangle Triangle1 = new Triangle();
            Triangle Triangle2 = new Triangle();

            if (SideToCalculate >= 1 && SideToCalculate <= 6)
            {

                string SideAIn = "";
                string SideBIn = "";
                string SideCIn = "";
                string SideXIn = "";
                string SideYIn = "";
                string SideZIn = "";
                bool SideCVisible = false;

                SideAIn = SideAInput.Text;
                SideBIn = SideBInput.Text;
                SideCIn = SideCInput.Text;
                SideXIn = SideXInput.Text;
                SideYIn = SideYInput.Text;
                SideZIn = SideZInput.Text;
                SideCVisible = SideCInput.Visible;

                Initialization.Init_SetTriangle(SideToCalculate, Triangle1, Triangle2, SideAIn, SideBIn, SideCIn, SideXIn, SideYIn, SideZIn, SideCVisible);

            }

            DoMath.DoMath_Triangle1Calculation(Triangle1, Triangle2);

            OutputBox.AppendText("Triangle1 Calculation is follows: " + Environment.NewLine +
                                 "Side A: " + Triangle1.SideA + Environment.NewLine +
                                 "Side B: " + Triangle1.SideB + Environment.NewLine +
                                 "Side C: " + Triangle1.SideC + Environment.NewLine);

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

            }

        }
    }
}
