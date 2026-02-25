using Models;

namespace Service
{
    public class PatientService : IPatientService
    {
        public readonly IPatientService _service;
        public PatientService(IPatientService service)
        {
            _service = service;
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }
    }
}