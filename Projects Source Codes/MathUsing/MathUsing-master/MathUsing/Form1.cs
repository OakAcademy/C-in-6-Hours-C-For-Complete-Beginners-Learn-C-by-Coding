using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathUsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        double firstNumberDouble, secondNumberDouble;
        decimal firstNumberDecimal, secondNumberDecimal;
        bool control = true;
        private void TxtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
       //     if (!char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar) ||
       //(e.KeyChar != '.'))
       //     {
       //         e.Handled = true;
       //     }

       //     // only allow one decimal point
       //     if ((e.KeyChar == '.') || ((sender as TextBox).Text.IndexOf('.') > -1))
       //     {
       //         e.Handled = true;
       //     }
        }
        void set2ParametersDouble()
        {
            if (txtFirstNumber.Text != "" && txtFirstNumber.Text != null && txtSecondNumber.Text != "" && txtSecondNumber.Text != null)
            {
                firstNumberDouble = Convert.ToDouble(txtFirstNumber.Text);
                secondNumberDouble = Convert.ToDouble(txtSecondNumber.Text);
                control = false;
            }
            else
                control = true;

        }
        void set2ParametersDecimal()
        {
            if (txtFirstNumber.Text != "" && txtFirstNumber.Text != null && txtSecondNumber.Text != "" && txtSecondNumber.Text != null)
            {
                firstNumberDecimal = Convert.ToDecimal(txtFirstNumber.Text);
                secondNumberDecimal = Convert.ToDecimal(txtSecondNumber.Text);
                control = false;
            }
            else
                control = true;

        }
        void set1ParametersDecimal()
        {
            if (txtFirstNumber.Text != "" && txtFirstNumber.Text != null)
            {
                firstNumberDecimal = Convert.ToDecimal(txtFirstNumber.Text);
                control = false;

            }
            else
                control = true;

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtSecondNumber.Clear();
            txtFirstNumber.Clear();
            txtResult.Clear();
            firstNumberDecimal = 0;
            secondNumberDecimal = 0;
            firstNumberDouble = 0;
            secondNumberDouble = 0;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            set2ParametersDecimal();
            if (!control)
            {
                txtResult.Text = Math.Min(firstNumberDecimal, secondNumberDecimal).ToString();

            }
            else
            {
                giveError();
            }
        }

        private void giveError()
        {
            MessageBox.Show("Please fill Neccessary fields!");
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            set1ParametersDecimal();
            if (!control)
            {
                txtResult.Text = Math.Max(firstNumberDecimal, secondNumberDecimal).ToString();

            }
            else
            {
                giveError();
            }
        }

        private void BtnAbs_Click(object sender, EventArgs e)
        {
            set1ParametersDecimal();
            if (!control)
            {
                txtResult.Text = Math.Abs(firstNumberDecimal).ToString();


            }
            else
            {
                giveError();
            }
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {
            set1ParametersDecimal();
            if (!control)
            {
                txtResult.Text = Math.Sign(firstNumberDecimal).ToString();


            }
            else
            {
                giveError();
            }
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            set1ParametersDouble();
            if (!control)
            {
                double aaa = Math.Tan(45);
                txtResult.Text = Math.Sin(firstNumberDouble).ToString();


            }
            else
            {
                giveError();
            }

        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            set1ParametersDouble();
            if (!control)
            {
                txtResult.Text = Math.Cos(firstNumberDouble).ToString();


            }
            else
            {
                giveError();
            }
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            set1ParametersDouble();
            if (!control)
            {
                txtResult.Text = Math.Tan(firstNumberDouble).ToString();


            }
            else
            {
                giveError();
            }
        }

        private void BtnPow_Click(object sender, EventArgs e)
        {
            set2ParametersDouble();
            if (!control)
            {
                txtResult.Text = Math.Pow(firstNumberDouble, secondNumberDouble).ToString();

            }
            else
            {
                giveError();
            }

        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            set1ParametersDouble();
            if (!control)
            {
                txtResult.Text = Math.Sqrt(firstNumberDouble).ToString();


            }
            else
            {
                giveError();
            }
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            set2ParametersDouble();
            if (!control)
            {
                txtResult.Text = Math.Log(firstNumberDouble, secondNumberDouble).ToString();

            }
            else
            {
                giveError();
            }

        }

        private void BtnLog10_Click(object sender, EventArgs e)
        {
            set1ParametersDouble();
            if (!control)
            {
                txtResult.Text = Math.Log10(firstNumberDouble).ToString();

            }
            else
            {
                giveError();
            }


        }

        private void BtnExp_Click(object sender, EventArgs e)
        {
            set1ParametersDouble();
            if (!control)
            {
                txtResult.Text = Math.Exp(firstNumberDouble).ToString();

            }
            else
            {
                giveError();
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "" || txtResult.Text != null )
            {
                txtFirstNumber.Text = txtResult.Text;
            }


        }

        private void TxtFirstNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        { 
       // {
       //     if (!char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar) ||
       //(e.KeyChar != '.'))
       //     {
       //         e.Handled = true;
       //     }

       //     // only allow one decimal point
       //     if ((e.KeyChar == '.') || ((sender as TextBox).Text.IndexOf('.') > -1))
       //     {
       //         e.Handled = true;
       //     }
        }

        void set1ParametersDouble()
        {
            if (txtFirstNumber.Text != "" && txtFirstNumber.Text != null)
            {
                firstNumberDouble = Convert.ToDouble(txtFirstNumber.Text);
                    control = false;
            }
            else
                control = true;

        }
        private void TxtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (!char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar) ||
        //(e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    // only allow one decimal point
        //    if ((e.KeyChar == '.') || ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        }
    }
}
