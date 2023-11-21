using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrucExample
{
    struct User
    {
        public string name;
        public int age;

        public void Print()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
}
