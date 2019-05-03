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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DimGray;
            BackColor = Color.Gray;
            foreach (Control control in panel1.Controls)
            {
                if (control is Button && (control.Name != "button6" && control.Name != "button7"))
                    control.ForeColor = Color.White;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Silver;
            BackColor = Color.White;
            foreach(Control control in panel1.Controls)
            {
                if(control is Button && (control.Name != "button6" && control.Name != "button7"))
                    control.ForeColor = Color.Black;
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
