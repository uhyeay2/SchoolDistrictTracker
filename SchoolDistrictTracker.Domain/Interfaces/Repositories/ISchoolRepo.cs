using SchoolDistrictTracker.Domain.Models;

namespace SchoolDistrictTracker.Domain.Interfaces.Repositories
{
    public interface ISchoolRepo
    {
        public Task<School?> GetSchoolByName(string name);

        public Task<School> GetSchoolByPostalCode(string name);
        
        public Task<int> InsertSchool(School school);

        public Task<int> UpdateSchool(School school);

        public Task<int> DeleteSchool(School school);
    }
}
