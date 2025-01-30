using LirmiChallenge.Client.Models;


namespace LirmiChallenge.Client.Services
{
    public class SubjectService
    {
        private readonly List<Subject> _subjects = new List<Subject>
       {
            new Subject { Id = 1, Name = "Matemáticas", Description = "Estudio de números y fórmulas" },
            new Subject { Id = 2, Name = "Historia", Description = "Eventos históricos relevantes" },
            new Subject { Id = 3, Name = "Ciencias", Description = "Exploración de fenómenos naturales"},
            new Subject { Id = 4, Name = "Ética", Description = "Reflexión sobre la moral y valores" }, 
            new Subject { Id = 5, Name = "Música", Description = "Expresión artística a través del sonido" }, 
            new Subject { Id = 6, Name = "Artes Plásticas", Description = "Creatividad visual y manual" }, 
            new Subject { Id = 7, Name = "Educación Física", Description = "Desarrollo físico y bienestar" },
            new Subject { Id = 8, Name = "Biología", Description = "Estudio de los seres vivos" } 
        };

        public Task<List<Subject>> GetAllSubjectsAsync()
        {
            return Task.FromResult(_subjects);
        }

        public Task AddSubjectAsync(Subject subject)
        {
            subject.Id = _subjects.Max(s => s.Id) + 1;
            _subjects.Add(subject);
            return Task.CompletedTask;
        }

        public Task UpdateSubjectAsync(Subject updatedSubject)
        {
            var subject = _subjects.FirstOrDefault(s => s.Id == updatedSubject.Id);
            if (subject != null)
            {
                subject.Name = updatedSubject.Name;
            }
            return Task.CompletedTask;
        }

        public Task DeleteSubjectAsync(int subjectId)
        {
            var subject = _subjects.FirstOrDefault(s => s.Id == subjectId);
            if (subject != null)
            {
                _subjects.Remove(subject);
            }
            return Task.CompletedTask;
        }
    }
}
