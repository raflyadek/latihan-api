using dto;
using Models;

namespace Repository
{
    public interface IPatientRepository
    {
        // get all  
        Task<List<Patient>> GetAllPatientAsync();
        Task<Patient?> GetPatientByIdAsync(long id);
        Task<IEnumerable<Patient?>> GetPatientFilterAsync(PatientSearchRequest filter);
        Task<Patient?> UpdatePatientAsync(long id, PatientUpdateRequest filter);
        // Task CreatePatient();
        // Task DeletePatient(int id);
        // Task UpdatePatient(Patient patient);
    }
}