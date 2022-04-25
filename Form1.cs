using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_rob_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox_ALL_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string str = tb.Text.PadLeft(1, '0');
            int dig = 0;

            if (str != "")
            {
                if (tb.Name == textBox_DEC.Name)
                    dig = Convert.ToInt32(str, 10);
                if (tb.Name == textBox_HEX.Name)
                    dig = Convert.ToInt32(str, 16);
                if (tb.Name == textBox_OCT.Name)
                    dig = Convert.ToInt32(str, 8);
                if (tb.Name == textBox_BIN.Name)
                    dig = Convert.ToInt32(str, 2);
            }
            string str_HEX = Convert.ToString(dig, 16);
            textBox_HEX.Text = str_HEX.ToUpper();

            HEX.Text = textBox_HEX.Text;
            HEX.Text = String.Format("{0:X}", dig);
            HEX.Text = Class1.MyConvert(HEX.Text, 4);

            string str_DEC = Convert.ToString(dig, 10);
            textBox_DEC.Text = str_DEC;
            DEC.Text = textBox_DEC.Text;
            DEC.Text = Class1.MyConvert(DEC.Text, 3);

            string str_OCT = Convert.ToString(dig, 8);
            textBox_OCT.Text = str_OCT;
            OCT.Text = textBox_OCT.Text;
            OCT.Text = Class1.MyConvert(OCT.Text, 3);

            string str_BIN = Convert.ToString(dig, 2);
            textBox_BIN.Text = str_BIN;
            BIN.Text = textBox_BIN.Text;
            BIN.Text = Class1.MyConvert(BIN.Text, 4);

            int count = BIN.Text.ToCharArray().Where(i => i == ' ').Count();
            int len = textBox_BIN.Text.Length;
            int a = 4 - len % 4;
            len = BIN.Text.Length;
            BIN.Text = BIN.Text.PadLeft(len + a, '0');

        }

        private void textBox_DEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Name == textBox_HEX.Name)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar >= 'A' && e.KeyChar <= 'F'))
                {
                    e.Handled = true;
                }
            }
            if (tb.Name == textBox_DEC.Name)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (tb.Name == textBox_BIN.Name)
            {
                if (!char.IsControl(e.KeyChar) && e.KeyChar != '0' && e.KeyChar != '1')
                {
                    e.Handled = true;
                }
            }
            if (tb.Name == textBox_OCT.Name)
            {
                if (!char.IsControl(e.KeyChar) && !(e.KeyChar >= '0' && e.KeyChar <= '7'))
                {
                    e.Handled = true;
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
