namespace InternshipTest.Person
{
    public class Student
    {
        public Student(string name, Knowledge knowledge)
        {
            this.studentName = name;
            this.knowledge = knowledge;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }
        
        public string studentName;
        public Knowledge knowledge;
    }
}