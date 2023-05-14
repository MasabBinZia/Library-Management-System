using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryManagementFinal
{
    class Books:Abstract
    {
        public List<string> books = new List<string>();

        public Books()
        {
            if (File.Exists("books.txt"))
            {
                using (StreamReader sr = File.OpenText("books.txt"))
                {
                    string line = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        books.Add(line);
                    }
                }

            }
        }
        public override void filing()
        {

            using (StreamWriter sw = File.CreateText("books.txt"))
            {
                foreach (string line in books)
                {
                    sw.WriteLine(line);
                }
            }

        }



        public override void insert(string data)
        {
            books.Add(data);
            filing();
        }

        public override void update(int id, string data)
        {
            books[id] = data;
            filing();
        }

        public override void delete(int id)
        {
            books.RemoveAt(id);
            filing();
        }
    }
}
