using InternshipTest.Person;
using System;
namespace InternshipTest.Institution
{
    public class University
    {
        public University(string name)
        {
            this.universityName = name;
        }

        public void AddStudent(Student student)
        {
            this.students[this.studentsCount] = student;
            this.studentsCount++;
        }
         public string GetUniversityName()
        {
            return this.universityName;
        }
        public string GetStudents()
        {
            string ret = "";
            for (int i = 0; i < this.studentsCount; i++)
            {
                ret += this.students[i].studentName + ": " + this.students[i].knowledge.level + "\n";
            }
            return ret;
        }
        public string GetStudentsForInternship()
        {
            string ret = "";
            for (int i = 0; i < this.studentsCount; i++)
            {
                if (this.students[i].knowledge.level > 3)
                ret += this.students[i].studentName + ": " + this.students[i].knowledge.level + "\n";
            }
            return ret;
        }
        private string universityName;
        private Student[] students = new Student[100];
        private int studentsCount = 0;
    }
}
