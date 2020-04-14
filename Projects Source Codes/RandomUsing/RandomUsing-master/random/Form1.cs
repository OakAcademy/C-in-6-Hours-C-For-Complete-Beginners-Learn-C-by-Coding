using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            byte[] Array = new byte[10];
            random.NextBytes(Array);
            string result = "";
            string allValid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_-=+{}:;\\<>?|,./`~[]'";

            for (int i = 0; i < 6; i++)
            {
                result += allValid[random.Next(0, Convert.ToInt32(allValid.Length))];
            }
            label1.Text = result;
        }

        public static string GenerateCoupon(int length)
        {
            string result = string.Empty;
            Random random = new Random((int)DateTime.Now.Ticks);
            List<string> characters = new List<string>() { };
            for (int i = 48; i < 58; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 65; i < 91; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 97; i < 123; i++)
            {
                characters.Add(((char)i).ToString());
            }
            for (int i = 0; i < length; i++)
            {
                result += characters[random.Next(0, characters.Count)];
                Thread.Sleep(1);
            }
            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            byte[] Array = new byte[5];
            random.NextBytes(Array);
            label1.Text = Array[0].ToString();
            label2.Text = Array[1].ToString();
            label3.Text = Array[2].ToString();
            label4.Text = Array[3].ToString();
            label5.Text = Array[4].ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = rnd.Next(10).ToString();
            label2.Text = rnd.Next(10).ToString();
            label3.Text = rnd.Next(10).ToString();
            label4.Text = rnd.Next(10).ToString();
            label5.Text = rnd.Next(10).ToString();
        }
    }
}
