using LirmiChallenge.Client.Models;

namespace LirmiChallenge.Client.Services
{
    public class CourseService
    {
        private readonly List<Course> _courses = new List<Course>
        {
            new Course { Id = 1, Name = "Primaria 1", Color = "#0000ff" },
            new Course { Id = 2, Name = "Primaria 2", Color = "#008000"}
        };

        public Task<List<Course>> GetAllCoursesAsync()
        {
            return Task.FromResult(_courses);
        }

        public Task<Course?> GetCourseByIdAsync(int id)
        {
            var course = _courses.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(course);
        }
       
        public Task AddCourseAsync(Course course)
        {
            course.Id = _courses.Max(c => c.Id) + 1;
            _courses.Add(course);
            return Task.CompletedTask;
        }

      
        public Task UpdateCourseAsync(Course updatedCourse)
        {
            var course = _courses.FirstOrDefault(c => c.Id == updatedCourse.Id);
            if (course != null)
            {
                course.Name = updatedCourse.Name;
                course.Color = updatedCourse.Color;
            }
            return Task.CompletedTask;
        }

        
        public Task DeleteCourseAsync(int courseId)
        {
            var course = _courses.FirstOrDefault(c => c.Id == courseId);
            if (course != null)
            {
                _courses.Remove(course);
            }
            return Task.CompletedTask;
        }
    }
}
