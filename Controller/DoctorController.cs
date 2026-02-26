using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controller
{
[ApiController]
[Route("doctor")]
    public class DoctorController : ControllerBase
    {
        public readonly IDoctorService _service;
        public DoctorController(IDoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var doctor = await _service.GetAllDoctorAsync();

            return Ok(new { data = doctor});
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var doctor = await _service.GetDoctorByIdAsync(id);

            return Ok(new { data = doctor});
        }
    }
}