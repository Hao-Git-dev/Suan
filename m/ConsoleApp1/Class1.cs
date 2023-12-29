using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1 : Interface1
    {
        public string name { get; set; }

        public void Test(ref string a)
        {
            a = name;
        }
        public Class1(string name)
        {
            this.name = name;
        }
    }
}
