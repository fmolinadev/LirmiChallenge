namespace LirmiChallenge.Client.Models
{
   public class Course
    {
        public int Id { get; set; } 
        public required string Name { get; set; } 
        public required string Color { get; set; } 
    
        public List<Student> Students { get; set; } = new List<Student>(); 
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public int TotalStudents => Students.Count;
        public int TotalSubject => Subjects.Count;
    }
}
