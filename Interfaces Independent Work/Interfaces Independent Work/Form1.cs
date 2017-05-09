using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;


namespace Interfaces_Independent_Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 ss = new Form3();
            ss.Owner = this;
            ss.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 ss = new Form2();
            ss.Owner = this;
            ss.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 ss = new Form2();
            ss.Owner = this;
            ss.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
