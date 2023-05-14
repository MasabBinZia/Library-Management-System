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
    public partial class Form10 : Form
    {
        public string label;
        
        public Form10(string text)
        {
            InitializeComponent();
            this.label = text;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
        }    

        private void button1_Click_1(object sender, EventArgs e)
        {
            string studentname = textBox1.Text;
            string fathername = textBox2.Text;
            string address = textBox3.Text;
            int age = Convert.ToInt32(textBox4.Text);
            int phno = Convert.ToInt32(textBox5.Text);


            string data = studentname + "," + fathername + "," + address + "," + age + "," + phno;
            if (label == "Books")
            {
                Books obj = new Books();
                obj.insert(data);
            }
            else if (label == "Students")
            {
                Students obj = new Students();
                obj.insert(data);
            }
            this.Close();
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }             
    }
}
