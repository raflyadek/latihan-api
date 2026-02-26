using Models;

namespace Repository
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> GetAllDoctorAsync();
        Task<Doctor?> GetDoctorByIdAsync(long id);
    }
}