using LirmiChallenge.Client.Models;


namespace LirmiChallenge.Client.Services
{
    public class SubjectService
    {
        private readonly List<Subject> _subjects = new List<Subject>
       {
        new Subject { Id = 1, Name = "Matemáticas", Description = "Estudio de números y fórmulas" },
        new Subject { Id = 2, Name = "Historia", Description = "Eventos históricos relevantes" },
        new Subject { Id = 3, Name = "Ciencias", Description = "Exploración de fenómenos naturales" }
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
