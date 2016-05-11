using CalculateAngelInvestorRatio.Properties;
using System;
using System.Windows.Forms;

namespace CalculateAngelInvestorRatio
{
    /// <summary>
    /// 0=RATIO,1=TOTALANGELS,2=LIFETIMEEARNINGS
    /// </summary>
    enum CALCULATEOPTIONS { RATIO, TOTALANGELS, LIFETIMEEARNINGS };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CALCULATEOPTIONS CurrentOption = CALCULATEOPTIONS.RATIO;
        const String MSG_INVALIDVALUES = "Invalid values!";
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double lifetimeearnings = 0;
            double totalangels = 0;
            double ratio = 0;
            bool convertsucess = true;
            double tmp_exp;
            if (CurrentOption != CALCULATEOPTIONS.LIFETIMEEARNINGS)
            {
                tmp_exp = (double)numExpEarnings.Value;
                if(!TryAssignDouble(txtLifetimeEarnings.Text, ref lifetimeearnings, tmp_exp))
                    convertsucess = false;
            }
            if (CurrentOption != CALCULATEOPTIONS.RATIO)
            {
                if(!TryAssignDouble(txtRatio.Text, ref ratio) || ratio==0)
                    convertsucess = false;
            }
            if (CurrentOption != CALCULATEOPTIONS.TOTALANGELS)
            {
                tmp_exp = (double)numExpAngels.Value;
                if (!TryAssignDouble(txtTotalAngels.Text, ref totalangels, tmp_exp))
                    convertsucess = false;
            }

            if (convertsucess)
            {
                Calculate(ref ratio, ref totalangels, ref lifetimeearnings);
                UpdateIllionsLabels();
            }
            else
            {
                MessageBox.Show(MSG_INVALIDVALUES);
            }
        }
        bool TryAssignDouble(String text,ref double value)
        {
            double exp = 0;
            return TryAssignDouble(text, ref value, exp);
        }
        bool TryAssignDouble(String text, ref double value, double exp)
        {
            if (double.TryParse(text, out value))
            {
                value = value * Math.Pow(10, exp);
                return true;
            }
            else
            {
                return false;
            }
        }

        void Calculate(ref double ratio, ref double totalangels, ref double lifetimeearnings)
        {
            //https://www.wolframalpha.com/input/?i=150*sqrt%28x%2F10^15%29+plot+0%3Cx%3C10^16
            double basevalue = Math.Pow(10, 15);
            switch (CurrentOption)
            {
                case CALCULATEOPTIONS.RATIO:
                    ratio = Math.Floor(totalangels / Math.Sqrt((lifetimeearnings / basevalue)));
                    txtRatio.Text = ratio.ToString();
                    break;
                case CALCULATEOPTIONS.TOTALANGELS:
                    totalangels = ratio * Math.Sqrt((lifetimeearnings / basevalue));
                    AssignMantissaAndExp(ref txtTotalAngels, ref numExpAngels, totalangels);
                    break;
                case CALCULATEOPTIONS.LIFETIMEEARNINGS:
                    lifetimeearnings = basevalue * (Math.Pow((totalangels / ratio), 2));
                    AssignMantissaAndExp(ref txtLifetimeEarnings, ref numExpEarnings, lifetimeearnings);
                    break;
            }
        }
        void GenerateMantissaAndExp(double value, out double mantissa, out int exp)
        {
            exp = (int)Math.Log10(value);
            mantissa = value / (Math.Pow(10, exp));
        }
        void AssignMantissaAndExp(ref TextBox txt, ref NumericUpDown num, double value)
        {
            double mantissa;
            int exp;
            GenerateMantissaAndExp(value, out mantissa, out exp);
            txt.Text = $"{ mantissa * Math.Pow(10, exp % 3):N3}";
            num.Value = Convert.ToInt32(exp / 3) * 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectOption();
            UpdateIllionsLabels();
        }

        void SelectOption()
        {
            txtRatio.ReadOnly = false;
            txtRatio.TabStop = true;
            txtTotalAngels.ReadOnly = false;
            txtTotalAngels.TabStop = true;
            numExpAngels.ReadOnly = false;
            numExpAngels.TabStop = true;
            txtLifetimeEarnings.ReadOnly = false;
            txtLifetimeEarnings.TabStop = true;
            numExpEarnings.ReadOnly = false;
            numExpEarnings.TabStop = true;

            if (rbTotalAngels.Checked)
            {
                txtTotalAngels.ReadOnly = true;
                txtTotalAngels.TabStop = false;
                numExpAngels.ReadOnly = true;
                numExpAngels.TabStop = false;
                CurrentOption = CALCULATEOPTIONS.TOTALANGELS;
                pictureBox1.Image = Resources.formula_angels;
            }
            else if (rbLifetimeEarnings.Checked)
            {
                txtLifetimeEarnings.ReadOnly = true;
                txtLifetimeEarnings.TabStop = false;
                numExpEarnings.ReadOnly = true;
                numExpEarnings.TabStop = false;
                CurrentOption = CALCULATEOPTIONS.LIFETIMEEARNINGS;
                pictureBox1.Image = Resources.formula_earnings;
            }
            else
            {
                txtRatio.ReadOnly = true;
                txtRatio.TabStop = false;
                CurrentOption = CALCULATEOPTIONS.RATIO;
                pictureBox1.Image = Resources.formula_ratio;
            }
        }

        private void rbRatio_CheckedChanged(object sender, EventArgs e)
        {
            SelectOption();
        }
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            //e.Handled = true;
            UpdateIllionsLabels();
        }

        enum ILLIONS
        {
            //https://github.com/Slimmmo/Slimmmo.github.io/blob/master/js/main.js
            Million = 2
            , Billion
            , Trillion
            , Quadrillion
            , Quintillion
            , Sextillion
            , Septillion
            , Octillion
            , Nonillion
            , Decillion
            , Undecillion
            , Duodecillion
            , Tredecillion
            , Quattuordecillion
            , Quindecillion
            , Sexdecillion
            , Septendecillion
            , Octodecillion
            , Novemdecillion
            , Vigintillion
            , Unvigintillion
            , Duovigintillion
            , Tresvigintillion
            , Quattuorvigintillion
            , Quinvigintillion
            , Sexvigintillion
            , Septenvigintillion
            , Octovigintillion
            , Novemvigintillion
            , Trigintillion
            , Untrigintillion
            , Duotrigintillion
            , Tretrigintillion
            , Quattuortrigintillion
            , Quintrigintillion
            , Sextrigintillion
            , Septentrigintillion
            , Octotrigintillion
            , Novemtrigintillion
            , Quadragintillion
            , Unquadragintillion
            , Duoquadragintillion
            , Trequadragintillion
            , Quattuorquadragintillion
            , Quinquadragintillion
            , Sexquadragintillion
            , Septquadragintillion
            , Octoquadragintillion
            , Novemquadragintillion
            , Quinquagintillion
            , Unquinquagintillion
            , Duoquinquagintillion
            , Trequinquagintillion
            , Quattuorquinquagintillion
            , Quinquinquagintillion
            , Sexquinquagintillion
            , Septquinquagintillion
            , Octoquinquagintillion
            , Novemquinquagintillion
            , Sexagintillion
            , Unsexagintillion
            , Duosexagintillion
            , Tresexagintillion
            , Quattuorsexagintillion
            , Quinsexagintillion
            , Sexsexagintillion
            , Septsexagintillion
            , Octosexagintillion
            , Novemsexagintillion
            , Septuagintillion
            , Unseptuagintillion
            , Duoseptuagintillion
            , Treseptuagintillion
            , Quattuorseptuagintillion
            , Quinseptuagintillion
            , Sexseptuagintillion
            , Septseptuagintillion
            , Octoseptuagintillion
            , Novemseptuagintillion
            , Octogintillion
            , Unoctogintillion
            , Duooctogintillion
            , Treoctogintillion
            , Quattuoroctogintillion
            , Quinoctogintillion
            , Sexoctogintillion
            , Septoctogintillion
            , Octooctogintillion
            , Novemoctogintillion
            , Nonagintillion
            , Unnonagintillion
            , Duononagintillion
            , Trenonagintillion
            , Quattuornonagintillion
            , Quinnonagintillion
            , Sexnonagintillion
            , Septnonagintillion
            , Onctononagintillion
            , Novemnonagintillion
            , Centillion
            , Uncentillion
        }
        void UpdateIllionsLabels()
        {
            //Earnings
            lblIllionsEarnings.Text = ReturnIllionsLabelText(numExpEarnings, txtLifetimeEarnings);

            //Angels
            lblIllionsAngels.Text = ReturnIllionsLabelText(numExpAngels, txtTotalAngels);
        }
        String ReturnIllionsLabelText(NumericUpDown num, TextBox txt)
        {
            String _return = "";
            double _value = 0;
            bool sucess = true;
            int exp = 0;
            double mantissa;

            if(TryAssignDouble(txt.Text,ref _value,(double)num.Value))
            {
                if (_value == 0)
                {
                    sucess = false;
                    _return = "0";
                }
                else
                {
                    if (double.IsInfinity(_value))
                    {
                        sucess = false;
                        _return = MSG_INVALIDVALUES;
                    }
                }
            }
            else
            {
                sucess = false;
                _return = MSG_INVALIDVALUES;
            }
            if (sucess)
            {
                GenerateMantissaAndExp(_value, out mantissa, out exp);
                _return = $"{ mantissa * Math.Pow(10, exp >= 6 ? exp % 3 : exp)}";
                if (exp >= 6)
                    _return += $" {(ILLIONS)(exp / 3)}";
            }
            return _return;
        }

        private void numExpEarnings_ValueChanged(object sender, EventArgs e)
        {
            UpdateIllionsLabels();
        }

        private void txtLifetimeEarnings_TextChanged(object sender, EventArgs e)
        {
            UpdateIllionsLabels();
        }

        private void numExpEarnings_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateIllionsLabels();
        }
    }
}
