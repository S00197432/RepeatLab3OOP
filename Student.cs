﻿using System;
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
        public Student(string name, string dob, List<Subject> subjects)
        {
            Name = name;
            DOB = dob;
            SubjectList = subjects;
        }
        
        public override string ToString()
        {
            return string.Format($"{Name} {DOB} {SubjectList}");
        }
        
    }
}
