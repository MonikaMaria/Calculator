using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void adding_Click(object sender, EventArgs e)
        {
            Fraction frac1 = ParseAndValidateInput(value1.Text);
            Fraction frac2 = ParseAndValidateInput(value2.Text);

            if (frac1 == null || frac2 == null)
                return;

            DisplayProperTypeResult(frac1 + frac2, adding.Text);
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            Fraction frac1 = ParseAndValidateInput(value1.Text);
            Fraction frac2 = ParseAndValidateInput(value2.Text);

            if (frac1 == null || frac2 == null)
                return;

            DisplayProperTypeResult(frac1 - frac2, subtraction.Text);
        }

        private void division_Click(object sender, EventArgs e)
        {
            Fraction frac1 = ParseAndValidateInput(value1.Text);
            Fraction frac2 = ParseAndValidateInput(value2.Text);

            if (frac1 == null || frac2 == null)
                return;

            DisplayProperTypeResult(frac1/frac2, division.Text);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            Fraction frac1 = ParseAndValidateInput(value1.Text);
            Fraction frac2 = ParseAndValidateInput(value2.Text);

            if (frac1 == null || frac2 == null)
                return;

            DisplayProperTypeResult(frac1*frac2, multiplication.Text);
        }

        public void power_Click(object sender, EventArgs e)
        {
            Fraction baseValue = ParseAndValidateInput(value1.Text);
            int powerValue;

            if (!int.TryParse(value2.Text, out powerValue))
            {
                MessageBox.Show("Proszę podać prawidłową wartość potęgi.", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DisplayProperTypeResult(baseValue ^ powerValue, power.Text);
        }

        private void root_Click(object sender, EventArgs e)
        {
            Fraction baseOfRoot = ParseAndValidateInput(valueToRoot.Text);

            if (baseOfRoot == null)
                return;

            double result = Fraction.Root(baseOfRoot);
            string resultToDisplay = result.ToString(CultureInfo.CurrentCulture);

            DisplayProperTypeResult(ParseAndValidateInput(resultToDisplay), "sqrt");
        }

        private Fraction ParseAndValidateInput(string value)
        {
            Fraction fraction;

            try
            {
                Fraction.TryParse(value, out fraction);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Proszę podać prawidłową wartość.\n{0}", ex.Message), 
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return fraction;
        }

        private void DisplayProperTypeResult(Fraction result, string operationSign)
        {
            if (fractionResult.Checked)
                DisplayResult(result, operationSign);
            else
                DisplayResult(Fraction.ParseFractionToFloat(result), operationSign);
        }

        private void DisplayResult(object result, string operationSign)
        {
            history.AppendText(string.Format("{0} {1} {2} = {3}\n", value1.Text, operationSign, value2.Text, result));
            MessageBox.Show(string.Format("Wynik to: {0}", result), "Wynik działania");
            clearingHistory.Enabled = true;
        }

        private void closing_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearingHistory_Click(object sender, EventArgs e)
        {
            if (clearingHistory.Enabled)
            {
                history.Clear();
                clearingHistory.Enabled = false;
            }
        }
    }
}
