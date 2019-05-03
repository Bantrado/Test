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
            string[] usernames;
            string[] passwords;
            usernames = new string[] { "johndoe492", "theresabrown582", "masonjackson938", "kimmillar153" };
            passwords = new string[] { "ALCS492", "ALCS582","ALCS938","ALCS153" };
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
                for (int i = 0; i < usernames.Length; i++)
                {
                    if (usernames[i] == textBox1.Text && passwords[i] == textBox2.Text)
                    {
                        Form tempForm1 = new Form1();
                        this.Hide();
                        tempForm1.Show();
                    }
                    else
                    {
                        ErrorHandle.Text = "Username or password is incorrect.";
                    }
                }
            }
        }
    }
}
