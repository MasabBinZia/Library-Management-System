using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryManagementFinal
{
    class Borrow:Abstract
    {
        public List<string> borrow = new List<string>();

        public Borrow()
        {
            if (File.Exists("borrow.txt"))
            {
                using (StreamReader sr = File.OpenText("borrow.txt"))
                {
                    string line = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        borrow.Add(line);
                    }
                }

            }
        }
        public  override void filing()
        {

            using (StreamWriter sw = File.CreateText("borrow.txt"))
            {
                foreach (string line in borrow)
                {
                     sw.WriteLine(line);
                }
            }

        }

        public override void insert(string data)
        {
            borrow.Add(data);
            filing();
        }

        public override void update(int id,string data)
        {
            borrow[id] = data;
            filing();
        }

        public override void delete(int id)
        {
            borrow.RemoveAt(id);
            filing();
        }

    }
}
