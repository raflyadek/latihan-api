using dto;
using Microsoft.AspNetCore.Mvc;
using Services;

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

        // [HttpGet]
        // public async Task<IActionResult> GetAll()
        // {
        //     var patient = await _service.GetAllAsync();
        //     return Ok(patient);
        // }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetById([FromRoute]long id)
        {
            Console.WriteLine($"id: {id}");
            var patient = await _service.GetByIdAsync(id);
            return Ok(new { data = patient });
        }

        [HttpGet]
        public async Task<IActionResult> GetByFilter(
            [FromQuery] PatientSearchRequest filter)
        {
            var patient = await _service.GetPatientByFilterAsync(filter);
            return Ok(new { data = patient});
        }
    }
}