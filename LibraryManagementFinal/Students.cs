using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryManagementFinal
{
    class Students:Abstract
    {
        public List<string> students = new List<string>();

        public Students()
        {
            if (File.Exists("students.txt"))
            {
                using (StreamReader sr = File.OpenText("students.txt"))
                {
                    string line = null;

                    while ((line = sr.ReadLine()) != null)
                    {
                        students.Add(line);
                    }
                }

            }
        }
        public override void filing()
        {

            using (StreamWriter sw = File.CreateText("students.txt"))
            {
                foreach (string line in students)
                {
                    sw.WriteLine(line);
                }
            }

        }

       

        public override void insert(string data)
        {
            students.Add(data);
            filing();
        }

        public override void update(int id, string data)
        {
            students[id] = data;
            filing();
        }

        public override void delete(int id)
        {
            students.RemoveAt(id);
            filing();
        }
    }
}
