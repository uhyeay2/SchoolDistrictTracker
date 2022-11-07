using SchoolDistrictTracker.Domain.Enums;

namespace SchoolDistrictTracker.Domain.Models
{
    public class Student
    {
        public string FirstName { get; set; } = null!;

        public string LastName{ get; set; } = null!;

        public int StudentId { get; set; }

        public GradeLevel CurrentGrade { get; set; }

        public IEnumerable<Course> CurrentCourses { get; set; } = Enumerable.Empty<Course>();

        public IEnumerable<Course> PreviousCourses { get; set; } = Enumerable.Empty<Course>();

        public EmergencyContact EmergencyContact { get; set; } = null!;
    }
}
