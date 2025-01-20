
namespace LirmiChallenge.Client.Models
{
    public class Subject
    {
        public int Id { get; set; } 
        public required string Name { get; set; } 

        public required string Description { get; set; } 

        
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
