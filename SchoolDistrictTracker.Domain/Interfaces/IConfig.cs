namespace SchoolDistrictTracker.Domain.Interfaces
{
    public interface IConfig
    {
        public string GetConnectionString(string configSection);
    }
}
