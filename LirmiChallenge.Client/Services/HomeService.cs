using LirmiChallenge.Client.Services;
using System.Threading.Tasks;

namespace LirmiChallenge.Client.Services
{
    public class HomeService
    {
        private readonly StudentService _studentService;
        private readonly SubjectService _subjectService;
        private readonly CourseService _courseService;

        public HomeService(StudentService studentService, SubjectService subjectService, CourseService courseService)
        {
            _studentService = studentService;
            _subjectService = subjectService;
            _courseService = courseService;
        }

        public async Task<HomeSummary> GetHomeSummaryAsync()
        {
            var students = await _studentService.GetAllStudentsAsync();
            var subjects = await _subjectService.GetAllSubjectsAsync();
            var courses = await _courseService.GetAllCoursesAsync();

            return new HomeSummary
            {
                StudentsCount = students.Count,
                SubjectsCount = subjects.Count,
                CoursesCount = courses.Count
            };
        }
    }

    public class HomeSummary
    {
        public int StudentsCount { get; set; }
        public int SubjectsCount { get; set; }
        public int CoursesCount { get; set; }
    }
}
