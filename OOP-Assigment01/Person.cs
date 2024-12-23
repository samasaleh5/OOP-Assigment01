using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment01
{
    internal struct Person
    {
        public string Name { get; set; }
        public int age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }  
    }
}
