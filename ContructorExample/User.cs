using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorExample
{
    internal class User
    {
        string name;
        int age;

        public User():this("Kamoliddin")
        {

        }
        
        public User(string name)
        {

        }

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Deconstruct(out string personName, out int personAge)
        {
            personName = name;
            personAge = age;
        }
    }
}
