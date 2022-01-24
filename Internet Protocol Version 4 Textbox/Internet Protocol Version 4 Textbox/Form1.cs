using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Internet_Protocol_Version_4_Textbox
{
    public partial class Form1 : Form
    {
        int ip1, ip2, ip3, ip4; 
        public Form1()
        {
            InitializeComponent();
        }

    

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //do your stuff here...
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textbox1_Str;
            textbox1_Str = textBox1.Text;

            if (textBox1.Text.Length == 3)//if length equals to 3 focus next textbox
                textBox2.Focus();

            if (textbox1_Str.Contains("."))//if dot is pressed, remove '.' and focus next textbox
            {
                textBox1.Text = textbox1_Str.Replace(".", "");
                if (!(textBox1.Text == ""))//if the textbox is'nt null, focus next textbox
                    textBox2.Focus();
            }

            if (textBox1.Text == "")
                return;

            ip1 = Convert.ToInt16(textBox1.Text);
            if (ip1 > 223)//show an error and fix the incorrect ip entered
            {
                MessageBox.Show(ip1 + " is not a valid entry. please specify a value between 1 and 223.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "223";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textbox2_Str;
            textbox2_Str = textBox2.Text;

            if (textBox2.Text.Length == 3)//if length equals to 3 focus next textbox
                textBox3.Focus();

            if (textbox2_Str.Contains("."))//if dot is pressed, remove '.' and focus next textbox
            {
                textBox2.Text = textbox2_Str.Replace(".", "");
                if (!(textBox2.Text == ""))//if the textbox is'nt null, focus next textbox
                    textBox3.Focus();
            }

            if (textBox2.Text == "")
                return;

            ip2 = Convert.ToInt16(textBox2.Text);//show an error and fix the incorrect ip entered
            if (ip2 > 225)
            {
                MessageBox.Show(ip2 + " is not a valid entry. please specify a value between 0 and 225.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "225";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string textbox3_Str;
            textbox3_Str = textBox3.Text;

            if (textBox3.Text.Length == 3)//if length equals to 3 focus next textbox
                textBox4.Focus();

            if (textbox3_Str.Contains("."))//if dot is pressed, remove '.' and focus next textbox
            {
                textBox3.Text = textbox3_Str.Replace(".", "");
                if (!(textBox3.Text == ""))//if the textbox is'nt null, focus next textbox
                    textBox4.Focus();
            }
            if (textBox3.Text == "")
                return;

            ip3 = Convert.ToInt16(textBox3.Text);
            if (ip3 > 225)//show an error and fix the incorrect ip entered
            {
                MessageBox.Show(ip3 + " is not a valid entry. please specify a value between 0 and 225.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "225";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Contains("."))//if dot is pressed, remove '.' character. in this case no focus needed!
                textBox4.Text = textBox4.Text.Replace(".", "");

            if (textBox4.Text == "")
                return;

            ip4 = Convert.ToInt16(textBox4.Text);
            if (ip4 > 225)//show an error and fix the incorrect ip entered
            {
                MessageBox.Show(ip4 + " is not a valid entry. please specify a value between 0 and 225.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Text = "225";
            }
        }

    
    }
}
