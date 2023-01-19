using InMemoryCaching.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryCaching.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly DataContext _context;

        public VehicleService(DataContext context)
        {
            _context = context;
        }
        public async Task<Vehicle> CreateVehicle(Vehicle newVehicle)
        {
            await _context.Vehicles.AddAsync(newVehicle);
            await _context.SaveChangesAsync();
            return newVehicle;
            

        }

        public async Task<Vehicle> DeleteVehicle(int vehicleId)
        {
            var vehicle=await _context.Vehicles.Where(x=>x.Id==vehicleId).FirstOrDefaultAsync();    
            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();
            return vehicle; 
        }

        public async Task<List<Vehicle>> GetAllVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        
        }

        public async Task<Vehicle> GetVehicleById(int vehicleId)
        {
            return await _context.Vehicles.Where(x=>x.Id==vehicleId).FirstOrDefaultAsync();
        }

        public async Task<Vehicle> UpdateVehicle(int vehicleId, Vehicle updatedVehicle)
        {
            var vehicle = await _context.Vehicles.Where(x => x.Id == vehicleId).FirstOrDefaultAsync();
            vehicle.Manufacturer = updatedVehicle.Manufacturer;
            vehicle.Model = updatedVehicle.Model;
            vehicle.Fuel = updatedVehicle.Fuel;
            vehicle.Vin = updatedVehicle.Vin;
            vehicle.Type = updatedVehicle.Type;

            await _context.SaveChangesAsync();
            return vehicle;
        }
    }
}
