using LirmiChallenge.Client.Models;

namespace LirmiChallenge.Client.Services
{
    public class StudentService
    {
        private readonly List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "María", Lastname = "Pérez", Age = 10, Grade = "Primero Básico" },
            new Student { Id = 2, Name = "Juan", Lastname = "López", Age = 12, Grade = "Segundo Básico" },
            new Student { Id = 3, Name = "Ana", Lastname = "García", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 4, Name = "Carlos", Lastname = "Rodríguez", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 5, Name = "Sofía", Lastname = "Martínez", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 6, Name = "Pedro", Lastname = "Sánchez", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 7, Name = "Laura", Lastname = "Díaz", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 8, Name = "Javier", Lastname = "Fernández", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 9, Name = "Isabel", Lastname = "González", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 10, Name = "Miguel", Lastname = "Ruiz", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 11, Name = "Elena", Lastname = "Álvarez", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 12, Name = "David", Lastname = "Morales", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 13, Name = "Carmen", Lastname = "Romero", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 14, Name = "Álvaro", Lastname = "Navarro", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 15, Name = "Lucía", Lastname = "Pérez", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 16, Name = "Hugo", Lastname = "Gómez", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 17, Name = "Daniela", Lastname = "López", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 18, Name = "Pablo", Lastname = "García", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 19, Name = "Valeria", Lastname = "Rodríguez", Age = 10, Grade = "Primero Básico" },
            new Student { Id = 20, Name = "Diego", Lastname = "Martínez", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 21, Name = "Andrea", Lastname = "Sánchez", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 22, Name = "Mario", Lastname = "Díaz", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 23, Name = "Carla", Lastname = "Fernández", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 24, Name = "Luis", Lastname = "González", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 25, Name = "Paula", Lastname = "Ruiz", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 26, Name = "Sergio", Lastname = "Álvarez", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 27, Name = "Isabella", Lastname = "Morales", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 28, Name = "Raúl", Lastname = "Romero", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 29, Name = "Natalia", Lastname = "Navarro", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 30, Name = "Adrián", Lastname = "Pérez", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 31, Name = "Daniel", Lastname = "Gómez", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 32, Name = "Carolina", Lastname = "López", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 33, Name = "Alejandro", Lastname = "García", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 34, Name = "Valentina", Lastname = "Rodríguez", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 35, Name = "Emilio", Lastname = "Martínez", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 36, Name = "Renata", Lastname = "Sánchez", Age = 11, Grade = "Tercero Básico" },
            new Student { Id = 37, Name = "Samuel", Lastname = "Díaz", Age = 9, Grade = "Primero Básico" },
            new Student { Id = 38, Name = "Antonia", Lastname = "Fernández", Age = 12, Grade = "Cuarto Básico" },
            new Student { Id = 39, Name = "Benjamín", Lastname = "González", Age = 10, Grade = "Segundo Básico" },
            new Student { Id = 40, Name = "Martina", Lastname = "Ruiz", Age = 11, Grade = "Tercero Básico" }
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
