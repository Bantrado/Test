using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text != "")
            {
                ErrorHandle.Text = "Please enter a username.";
            }
            else if (textBox2.Text == "" && textBox1.Text != "")
            {
                ErrorHandle.Text = "Please enter a password.";
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                ErrorHandle.Text = "Please enter a username and a password.";
            }
            else // Username + password entered
            {
                ErrorHandle.Text = "test success";
            }
        }
    }
}
