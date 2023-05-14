using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementFinal
{
    public partial class Form8 : Form
    {
        public string label;
        public Form8(string text)
        {
            InitializeComponent();
            this.label = text;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }
    }
}
