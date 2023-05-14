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
    
    public partial class Form3 : Form
    {
        public string label;
        public Form3(string text)
        {
            InitializeComponent();
            this.label = text;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (label == "Books")
            {
                Books obj = new Books();

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 5;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                tableLayoutPanel1.RowStyles.Add(new RowStyle() { Height = 60, SizeType = SizeType.Percent, });

                tableLayoutPanel1.Controls.Add(new Label() { Text = "Book Name", Font = new Font("Arial", 9, FontStyle.Bold) }, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Author Name", Font = new Font("Arial", 9, FontStyle.Bold) }, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Publisher", Font = new Font("Arial", 9, FontStyle.Bold) }, 2, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Book Price", Font = new Font("Arial", 9, FontStyle.Bold) }, 3, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Book Quantity", Font = new Font("Arial", 9, FontStyle.Bold) }, 4, tableLayoutPanel1.RowCount - 1);

                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;

                tableLayoutPanel1.AutoSize = true;

                for(int i=0;i<obj.books.Count;i++)
                { 
                    string [] arr = obj.books[i].Split(',');
                    tableLayoutPanel1.RowStyles.Add(new RowStyle() { Height = 60, SizeType = SizeType.Percent });
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[0] }, 0,i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[1]}, 1, i + 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[2] }, 2, i + 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[3] }, 3, i + 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[4] }, 4, i + 1);          
                }
            }
            else if (label == "Students")
            {
                Students obj = new Students();

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 5;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                tableLayoutPanel1.RowStyles.Add(new RowStyle() { Height = 60, SizeType = SizeType.Percent, });
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Student Name", Font = new Font("Arial", 9, FontStyle.Bold) }, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Father Name", Font = new Font("Arial", 9, FontStyle.Bold) }, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Address", Font = new Font("Arial", 9, FontStyle.Bold) }, 2, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Age", Font = new Font("Arial", 9, FontStyle.Bold) }, 3, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Phone Number", Font = new Font("Arial", 9, FontStyle.Bold) }, 4, tableLayoutPanel1.RowCount - 1);

                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;

                tableLayoutPanel1.AutoSize = true;

                for (int i = 0; i < obj.students.Count; i++)
                {
                    string[] arr = obj.students[i].Split(',');
                    tableLayoutPanel1.RowStyles.Add(new RowStyle() { Height = 60, SizeType = SizeType.Percent });
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[0] }, 0, i + 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[1] }, 1, i + 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[2] }, 2, i + 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[3] }, 3, i + 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[4] }, 4, i + 1);      
                }
            }
            else
            {
                Borrow obj = new Borrow();

                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.ColumnCount = 2;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                tableLayoutPanel1.RowStyles.Add(new RowStyle() { Height = 60, SizeType = SizeType.Percent, });
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Student Name", Font = new Font("Arial", 9, FontStyle.Bold) }, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Book Name", Font = new Font("Arial", 9, FontStyle.Bold) }, 1, tableLayoutPanel1.RowCount - 1);

                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;

                tableLayoutPanel1.AutoSize = true;

                for (int i = 0; i < obj.borrow.Count; i++)
                {
                    string[] arr = obj.borrow[i].Split(',');
                    tableLayoutPanel1.RowStyles.Add(new RowStyle() { Height = 60, SizeType = SizeType.Percent });
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[0] }, 0, i + 1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = arr[1] }, 1, i + 1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label == "Borrow")
            {
                Form7 f = new Form7();
                this.Visible = false;
                f.ShowDialog();
            }
            else if (label == "Students")
            {
                Form10 f = new Form10(label);
                this.Visible = false;
                f.ShowDialog();
            }
            else
            {
                Form4 f = new Form4(label);
                this.Visible = false;
                f.ShowDialog();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label == "Borrow")
            {
                Form8 f = new Form8("Borrow");
                this.Visible = false;
                f.Hide();
            }
            else if (label == "Students")
            {
                Form11 f = new Form11(label);
                this.Visible = false;
                f.ShowDialog();
            }
            else
            {
                Form5 f = new Form5(label);
                this.Visible = false;
                f.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label == "Borrow")
            {
                Form9 f = new Form9();
                this.Visible = false;
                f.ShowDialog();
            }
            else if (label == "Students")
            {
                Form12 f = new Form12(label);
                this.Visible = false;
                f.ShowDialog();
            }
            else
            {
                Form6 f = new Form6(label);
                this.Visible = false;
                f.ShowDialog();
            }  
        }

        private void tableLayoutPanel1_CellPaint_1(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column + e.Row) % 2 == 1)
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
        }
    }
}
