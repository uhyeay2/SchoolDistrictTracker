namespace SchoolDistrictTracker.Domain.Models
{
    public class School
    {
        public IEnumerable<Course> Courses { get; set; } = Enumerable.Empty<Course>();

        public IEnumerable<Instructor> Instructors { get; set; } = Enumerable.Empty<Instructor>();

        public IEnumerable<Student> Students { get; set; } = Enumerable.Empty<Student>();

        public string Name { get; set; } = null!;

        public string AddressLine1 { get; set; } = null!;

        public string AddressLine2 { get; set; } = string.Empty;

        public string City { get; set; } = null!;

        public string PostalCode { get; set; } = null!;

        public string State { get; set; } = null!;
    }
}
