using Models;

namespace Services
{
    public interface IPatientService
    {
        Task<List<Patient>> GetAllAsync();
        Task<Patient?> GetByIdAsync(long id);
        Task<Patient?> GetByNameAsync(string name);
    }
}