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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;

            int var = Convert.ToInt32(comboBox1.SelectedItem.ToString());

            Borrow obj = new Borrow();

            string[] arr = obj.borrow[var].Split(',');

            textBox1.Text = arr[0];
            textBox2.Text = arr[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;

            Borrow obj = new Borrow();
            for (int i = 0; i < obj.borrow.Count; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int var = Convert.ToInt32(comboBox1.SelectedItem.ToString());

            Borrow obj = new Borrow();

            obj.delete(var);

            this.Close();
        }
    }

}
