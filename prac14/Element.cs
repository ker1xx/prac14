using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace prac14
{
    internal class Element
    {
        public Element(string a, string b, string c, DateTime d, bool e)
        {
            name = a;
            type = b;
            description = c;
            date = d;
            isSpending = e;
        }
        public string name;
        public string type;
        public string description;
        public DateTime date;
        public bool isSpending;
    }
}
