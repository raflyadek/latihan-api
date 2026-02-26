using Models;

namespace Services
{
    public interface IPatientService
    {
        Task<List<Patient>> GetAllAsync();
        Task<Patient> GetByIdAsync(long id);
    }
}