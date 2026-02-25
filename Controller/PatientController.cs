using Microsoft.AspNetCore.Mvc;
using Service;

namespace Controller
{
[ApiController]
[Route("patient")]
    public class PatientController : ControllerBase
    {
        public readonly IPatientService _service;
        public PatientController(IPatientService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var patient = _service.GetAllAsync();
            return Ok(patient);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var patient = _service.GetByIdAsync(id);
            return Ok(patient);
        }
    }
}