using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counting2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        int divisibleTerm = 1;
        int firstNumber = 0, lastNumber = 0, controlNumber = 0;
        string divisibleNumber;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("9");
            cmbDivisibleTerm.Items.Add("10");


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
            {
                rbRed.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                txtDivisibleNumber.ForeColor = Color.Black;

            }
        }

        private void RbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                rbBlack.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                txtDivisibleNumber.ForeColor = Color.Red;

            }
        }
        string textcolor;
        private void RbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbBlack.Checked = false;
                 rbRed.Checked= false;
                rbGreen.Checked = false;
                txtDivisibleNumber.ForeColor = Color.Blue;

            }
        }

        private void RbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                rbBlack.Checked = false;
                rbRed.Checked = false;
                rbBlue.Checked = false;
                txtDivisibleNumber.ForeColor = Color.Green;

            }
        }
        
        private void ChBold_CheckedChanged(object sender, EventArgs e)
        {
            if(chBold.Checked)
            txtDivisibleNumber.Font = new Font(txtDivisibleNumber.Font.FontFamily, txtDivisibleNumber.Font.Size, FontStyle.Bold);
            else
                txtDivisibleNumber.Font = new Font(txtDivisibleNumber.Font.FontFamily, txtDivisibleNumber.Font.Size, FontStyle.Regular);

        }

        private void ChItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
                txtDivisibleNumber.Font = new Font(txtDivisibleNumber.Font.FontFamily, txtDivisibleNumber.Font.Size, FontStyle.Italic);
            else
                txtDivisibleNumber.Font = new Font(txtDivisibleNumber.Font.FontFamily, txtDivisibleNumber.Font.Size, FontStyle.Regular);

        }

        private void TxtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            if (txtStartFrom.Text == null || txtStartFrom.Text == "" || txtTo.Text == null || txtTo.Text == "")
            {
                MessageBox.Show("Please fill necessary fields!!");
            }
            else if (cmbDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please select divisible term");
            }
            else
            {
                txtDivisibleNumber.Clear();
              
                firstNumber = Convert.ToInt32(txtStartFrom.Text);
                lastNumber = Convert.ToInt32(txtTo.Text);
                for (int i = firstNumber; i <= lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        if (controlNumber % 10 == 0)
                        {
                            divisibleNumber += Environment.NewLine;
                        }
                        divisibleNumber += " " + i + " ";
                        controlNumber++;
                    }

                }
                txtDivisibleNumber.Text = divisibleNumber;
            }

        }

        private void CmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);
            label4.Text = "these Numbers Can be divided " + divisibleTerm;
        }
    }
}
