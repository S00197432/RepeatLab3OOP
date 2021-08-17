using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLab3OOP
{
    class Student
    {
        public string Name { get; set; }
        public string DOB { get; set; }
        public List<Subject> SubjectList { get; set; }
        public Student(string name, string dob)
        {
            Name = name;
            DOB = dob;
        }
        public override string ToString()
        {
            return string.Format($"{Name} {DOB} {SubjectList}");
        }
    }
}
