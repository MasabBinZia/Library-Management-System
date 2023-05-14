using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementFinal
{
    abstract class Abstract
    {
        public abstract void filing();
        public abstract void insert(string data);
        public abstract void update(int id,string data);
        public abstract void delete(int id);

    }
}
