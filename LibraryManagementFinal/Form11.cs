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
    public partial class Form11 : Form
    {
        public string label;
        public Form11(string text)
        {
            InitializeComponent();
            this.label = text;
        }
   
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            button1.Enabled = true;

            int var = Convert.ToInt32(comboBox1.SelectedItem.ToString());

            if (label == "Books")
            {
                Books obj = new Books();

                string[] arr = obj.books[var].Split(',');
                textBox1.Text = arr[0];
                textBox2.Text = arr[1];
                textBox3.Text = arr[2];
                textBox4.Text = arr[3];
                textBox5.Text = arr[4];

            }
            else if (label == "Students")
            {
                Students obj = new Students();

                string[] arr = obj.students[var].Split(',');
                textBox1.Text = arr[0];
                textBox2.Text = arr[1];
                textBox3.Text = arr[2];
                textBox4.Text = arr[3];
                textBox5.Text = arr[4];
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Enabled = false;

            if (label == "Books")
            {
                Books obj = new Books();
                for (int i = 0; i < obj.books.Count; i++)
                {
                    comboBox1.Items.Add(i);
                }

            }
            else if (label == "Students")
            {
                Students obj = new Students();
                for (int i = 0; i < obj.students.Count; i++)
                {
                    comboBox1.Items.Add(i);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int var = Convert.ToInt32(comboBox1.SelectedItem.ToString());

            string studentname = textBox1.Text;
            string fathername = textBox2.Text;
            string address = textBox3.Text;
            string age = textBox4.Text;
            string phno = textBox5.Text;

            string data = studentname + "," + fathername + "," + address + "," + age + "," + phno;

            if (label == "Books")
            {
                Books obj = new Books();
                obj.update(var,data);
            }
            else if (label == "Students")
            {
                Students obj = new Students();
                obj.update(var, data);


            }

            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


