using LirmiChallenge.Client.Models;

namespace LirmiChallenge.Client.Services
{
    public class StudentService
    {
        private readonly List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "María", Lastname = "Pérez", Age = 10, Grade = "Primaria 1" },
            new Student { Id = 2, Name = "Juan", Lastname = "López", Age = 12, Grade = "Primaria 2" },
            new Student { Id = 3, Name = "Ana", Lastname = "García", Age = 9, Grade = "Primaria 1" }
        };

        public Task<List<Student>> GetAllStudentsAsync()
        {
            return Task.FromResult(_students);
        }

        public Task AddStudentAsync(Student student)
        {
            student.Id = _students.Max(s => s.Id) + 1;
            _students.Add(student);
            return Task.CompletedTask;
        }

        public Task UpdateStudentAsync(Student updatedStudent)
        {
            var student = _students.FirstOrDefault(s => s.Id == updatedStudent.Id);
            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Lastname = updatedStudent.Lastname;
                student.Age = updatedStudent.Age;
                student.Grade = updatedStudent.Grade;
            }
            return Task.CompletedTask;
        }

        public Task DeleteStudentAsync(int studentId)
        {
            var student = _students.FirstOrDefault(s => s.Id == studentId);
            if (student != null)
            {
                _students.Remove(student);
            }
            return Task.CompletedTask;
        }
    }
}
