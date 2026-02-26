using Models;
using Repository;

namespace Services
{
    public class DoctorService : IDoctorService
    {
        public readonly IDoctorRepository _repo;
        public DoctorService(IDoctorRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Doctor>> GetAllDoctorAsync()
        {
            return await _repo.GetAllDoctorAsync();
        } 

        public async Task<Doctor> GetDoctorByIdAsync(long id)
        {
            return await _repo.GetDoctorByIdAsync(id);
        }
    }
}