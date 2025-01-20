namespace LirmiChallenge.Client.Models
{
   public class Student
    {
        public int Id { get; set; } 
        public required string Name { get; set; } 

        public required string Lastname { get; set; } 
        public int Age { get; set; } 
        public required string Grade { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
