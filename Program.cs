using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex", new Knowledge(3));
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(4)));
            university.AddStudent(new Student("Julia Veselkina", new Knowledge(2)));
            university.AddStudent(new Student("Maria Perechrest", new Knowledge(3)));
            university.AddStudent(new Student("Marian Tsap", new Knowledge(5)));

            Console.WriteLine("All students:");
            Console.WriteLine(university.GetStudents());

            Internship internship = new Internship("Interlink");
            internship.SetStudents(university.GetStudentsForInternship());
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
