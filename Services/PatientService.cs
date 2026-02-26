using Models;
using Repository;

namespace Services
{
    public class PatientService : IPatientService
    {
        public readonly IPatientRepository _repo;
        public PatientService(IPatientRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            return await _repo.GetAllPatientAsync();
        }

        public async Task<Patient> GetByIdAsync(long id)
        {
            return await _repo.GetPatientByIdAsync(id);
        }
    }
}