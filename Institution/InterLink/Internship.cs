namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public Internship(string name)
        {
            this.internshipName = name;
        }
        public void SetStudents(string names)
        {
            this.studentsNames = names;
        }
        public string GetStudents()
        {

            return this.studentsNames;
        }
        private string internshipName;
        private string studentsNames = "";
    }
}
