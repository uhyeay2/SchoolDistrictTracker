using Microsoft.EntityFrameworkCore;
using SchoolDistrictTracker.Data.DataConfig;
using SchoolDistrictTracker.Domain.Interfaces.Repositories;
using SchoolDistrictTracker.Domain.Models;

namespace SchoolDistrictTracker.Data.Repositories
{
    internal class SchoolRepository : ISchoolRepo
    {
        private readonly SchoolDistrictTrackerContext _dbContext;

        public SchoolRepository(SchoolDistrictTrackerContext context)
        {
            _dbContext = context;
        }

        public Task<int> DeleteSchool(School school)
        {
            throw new NotImplementedException();
        }

        public async Task<School?> GetSchoolByName(string name)
        {
            return await _dbContext.Schools.FirstOrDefaultAsync(x => x.Name == name);
        }

        public Task<School?> GetSchoolByPostalCode(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertSchool(School school)
        {
            await _dbContext.AddAsync(school);

            return await _dbContext.SaveChangesAsync();
        }

        public Task<int> UpdateSchool(School school)
        {
            throw new NotImplementedException();
        }
    }
}
