using InMemoryCaching.Models;
using InMemoryCaching.Services;
using Microsoft.AspNetCore.Mvc;

namespace InMemoryCaching.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _vehicleService.GetAllVehicles());
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message= ex.Message;
                return BadRequest(response);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await _vehicleService.GetVehicleById(id));
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = ex.Message;
                return BadRequest(response);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateV(Vehicle newVehicle)
        {
            try
            {
                return Ok(await _vehicleService.CreateVehicle(newVehicle) + $"{newVehicle.Model} Created!");
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = ex.Message;
                return BadRequest(response);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateV(int Id, Vehicle updatedVehicle)
        {
            try
            {
                return Ok(await _vehicleService.UpdateVehicle(Id, updatedVehicle));
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = ex.Message;
                return BadRequest(response);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return Ok(await _vehicleService.DeleteVehicle(id) +"Deleted!");
            }
            catch (Exception ex)
            {
                var response = new ServiceResponse();
                response.Success = false;
                response.Message = ex.Message;
                return BadRequest(response);
            }
        }
    }
}
