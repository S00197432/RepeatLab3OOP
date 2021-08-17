using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab3OOP
{
    public class Subject
    {
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year { get; set; }
        
        public Subject(string name, string lecturer, int year)
        {
            Name = name;
            Lecturer = lecturer;
            Year = year;
        }
        public Subject( string name, string lecturer) : this(name, lecturer, 0)
        {

        }
        public override string ToString()
        {
            return string.Format($"{Name} {Lecturer} {Year}");
        }

    }
}
