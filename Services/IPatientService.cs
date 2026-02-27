using dto;
using Models;

namespace Services
{
    public interface IPatientService
    {
        Task<List<Patient>> GetAllAsync();
        Task<Patient?> GetByIdAsync(long id);
        Task<IEnumerable<Patient?>> GetPatientByFilterAsync(PatientSearchRequest filter);
    }
}