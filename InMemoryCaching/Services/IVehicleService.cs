using InMemoryCaching.Models;

namespace InMemoryCaching.Services
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetAllVehicles();
        Task<Vehicle> GetVehicleById(int vehicleId);
        Task<Vehicle> DeleteVehicle(int vehicleId);
        Task<Vehicle> UpdateVehicle(int vehicleId,Vehicle updatedVehicle);
        Task<Vehicle> CreateVehicle(Vehicle newVehicle);
    }
}
