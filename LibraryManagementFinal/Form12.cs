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
    public partial class Form12 : Form
    {
        public string label;
        public Form12(string label)
        {
            InitializeComponent();
            this.label = label;
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

                Students obj = new Students();

                string[] arr = obj.students[var].Split(',');
                textBox1.Text = arr[0];
                textBox2.Text = arr[1];
                textBox3.Text = arr[2];
                textBox4.Text = arr[3];
                textBox5.Text = arr[4];

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Enabled = false;

                Students obj = new Students();
                for (int i = 0; i < obj.students.Count; i++)
                {
                    comboBox1.Items.Add(i);
                }
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int var = Convert.ToInt32(comboBox1.SelectedItem.ToString());

                Students obj = new Students();

                obj.delete(var);

                this.Close();

        }
    }
}