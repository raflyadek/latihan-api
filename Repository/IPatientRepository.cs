using Models;

namespace Repository
{
    public interface IPatientRepository
    {
        // get all  
        Task<List<Patient>> GetAllPatientAsync();
        Task<Patient?> GetPatientByIdAsync(long id);
        // Task CreatePatient();
        // Task DeletePatient(int id);
        // Task UpdatePatient(Patient patient);
    }
}