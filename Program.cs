using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepeatLab3OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject SBJ1 = new Subject("Databases", "Padraig Harte", 1);
            Subject SBJ2 = new Subject("Programming", "Vivion Kinsella", 1);
            Subject SBJ3 = new Subject("UX Design", "Adrian Durcan", 2);
            Subject SBJ4 = new Subject("OOP", "Keith McManus", 2);

            List<Subject> SubjectList = new List<Subject>();

            SubjectList.Add(SBJ1);
            SubjectList.Add(SBJ2);
            SubjectList.Add(SBJ3);
            SubjectList.Add(SBJ4);

            Student ST1 = new Student("Adam", "22/07/99");
            Student ST2 = new Student("Luke", "25/07/99");

            List<Student> STlist = new List<Student>();

            STlist.Add(ST1);
            STlist.Add(ST2);

            Display(STlist);
        }
        private static void Display(List<Student> STlist)
        {
             
            Console.WriteLine("\n{0,-20}{1,-25}{2,-10}", "Name--", "DOB--", "Subjects--");
            foreach (Student student in STlist)
            {
               
                Console.WriteLine($"{student.Name,-20}{student.DOB,-25}{student.SubjectList,-10}");
                
            }
        }
    }
}
