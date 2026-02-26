using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        public readonly AppDbContext _context;
        public DoctorRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Doctor>> GetAllDoctorAsync()
        {
            return await _context.Doctor.ToListAsync();
        }

        public async Task<Doctor?> GetDoctorByIdAsync(long id)
        {
            return await _context.Doctor.FindAsync(id);
        }
    }
}