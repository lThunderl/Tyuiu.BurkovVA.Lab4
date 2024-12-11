using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdinaryCalc.Lib;
using Form2;

namespace Tyuiu.BurkovVA.Lab4
{
    public partial class Form1 : Form
    {
        public string Sign;
        public string N1;
        public bool n2;
        OrdinaryCalculate OC = new OrdinaryCalculate();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_BVA_Click(object sender, EventArgs e)
        {

            

            if (n2)
            {
                n2 = false;
                textBoxResult_BVA.Text = "0";
            }
            Button B = (Button)sender;
            if (textBoxResult_BVA.Text == "0"){
                textBoxResult_BVA.Text = B.Text;
            }
            else
            textBoxResult_BVA.Text = textBoxResult_BVA.Text + B.Text;
        }

        private void buttonC_BVA_Click(object sender, EventArgs e)
        {
            textBoxResult_BVA.Text = "0";
        }

        private void buttonPlus_BVA_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            Sign = B.Text;
            N1 = textBoxResult_BVA.Text;
            n2 = true;

        }

        private void buttonRes_BVA_Click(object sender, EventArgs e)
        {
            
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBoxResult_BVA.Text);
            if(Sign == "+")
            {
                res = OC.CalcSumma(dn1, dn2 );
            }
            if (Sign == "-")
            {
                res = OC.CalcDifference(dn1, dn2);
            }
            if (Sign == "*")
            {
                res = OC.CalcMultiplication(dn1, dn2);
            }
            if (Sign == "/")
            {
                res = OC.CalcQuotient(dn1, dn2);
            }
            if (Sign == "%")
            {
                res = OC.CalcPercent(dn1, dn2);
            }

            n2 = true;
            textBoxResult_BVA.Text = Convert.ToString(res);
        }

        private void buttonSqrt_BVA_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBoxResult_BVA.Text);

            res = OC.CalcSqrt(dn);

            textBoxResult_BVA.Text = res.ToString();

        }

        private void buttonDouble_BVA_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBoxResult_BVA.Text);

            res = OC.CalcPow2(dn);

            textBoxResult_BVA.Text = res.ToString();
        }

        private void buttonDelX_BVA_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBoxResult_BVA.Text);

            res = OC.CalcOneQuo(dn);

            textBoxResult_BVA.Text = res.ToString();
        }

        private void buttonPlMn_BVA_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBoxResult_BVA.Text);

            res = OC.CalcChangeSign(dn);

            textBoxResult_BVA.Text = res.ToString();
        }

        private void buttonDot_BVA_Click(object sender, EventArgs e)
        {
            if (!textBoxResult_BVA.Text.Contains(","))
                textBoxResult_BVA.Text = textBoxResult_BVA.Text + ",";
        }

        private void buttonDelEl_BVA_Click(object sender, EventArgs e)
        {
           textBoxResult_BVA.Text = textBoxResult_BVA.Text.Substring(0, textBoxResult_BVA.Text.Length - 1);
            if (textBoxResult_BVA.Text == "")
            {
                textBoxResult_BVA.Text = "0";
            }
        }

        private void Options_BVA_Click(object sender, EventArgs e)
        {
            if (optionsPanel.Width == 0)
            {

                optionsPanel.Width = 200;
            }
            else optionsPanel.Width = 0;
        }

        private void button_arif_BVA_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
