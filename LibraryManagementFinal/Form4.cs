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
    public partial class Form4 : Form
    {
        public string label;
        
        public Form4(string text)
        {
            InitializeComponent();
            this.label = text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }    

        private void button1_Click(object sender, EventArgs e)
        {

            string bookname = textBox1.Text;
            string authorname = textBox2.Text;
            string bookpublication = textBox3.Text;
            int bookprice = Convert.ToInt32(textBox4.Text);
            int bookquantity = Convert.ToInt32(textBox5.Text);
          

                string data = bookname + "," + authorname + "," + bookpublication + "," + bookprice + "," + bookquantity;
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

         
        
    }
}
