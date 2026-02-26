using Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Services
{
    public interface IDoctorService
    {
        Task<List<Doctor>> GetAllDoctorAsync();
        Task<Doctor> GetDoctorByIdAsync(long id);
    }
}