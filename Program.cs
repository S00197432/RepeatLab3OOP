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

            var date1 = new DateTime(1999, 07, 22);
            var date2 = new DateTime(1999, 07, 25);

            var now = new DateTime(2021, 01, 01, 0, 0, 0);

            var age1 = (now.Year - date1.Year) * 365;
            var age2 = (now.Year - date2.Year) * 365;

            List<Subject> SubjectList = new List<Subject>();
            List<Subject> SubjectList1 = new List<Subject>();

            SubjectList.Add(SBJ1);
            SubjectList.Add(SBJ2);

            SubjectList1.Add(SBJ3);
            SubjectList1.Add(SBJ4);

            Student ST1 = new Student("Adam", "22/07/99",SubjectList, age1);
            Student ST2 = new Student("Luke", "25/07/99",SubjectList1, age2);

            List<Student> STlist = new List<Student>();

            STlist.Add(ST1);
            STlist.Add(ST2);

            Display(STlist);
        }
        private static void Display(List<Student> STlist)
        {
             
           
            foreach (Student student in STlist)
            {
               
                Console.WriteLine($"Name: {student.Name,-20}");
                Console.WriteLine($"Date Of Birth: {student.DOB,-25}");
                Console.WriteLine(string.Join($",", student.SubjectList)); // prints the list with a separator in between each of the elements
                Console.WriteLine($"{student.Name} is {student.Age} days old");
            }
        }
    }
}
