using InMemoryCaching.Models;
using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCaching.Services
{
    public class CachedVehicleService : IVehicleService
    {
        private const string VehicleListCacheKey = "VehicleList";
        private readonly IVehicleService _vehicleService;
        private readonly IMemoryCache _memoryCache;

        public CachedVehicleService(IVehicleService vehicleService,IMemoryCache memoryCache)
        {
            _vehicleService = vehicleService;
            _memoryCache = memoryCache;
        }
        public Task<Vehicle> CreateVehicle(Vehicle newVehicle)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> DeleteVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Vehicle>> GetAllVehicles()
        {
            var cacheOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(10))
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(30));

            if (_memoryCache.TryGetValue(VehicleListCacheKey,out List<Vehicle> query))
            {
                return query;
            }
            query = await _vehicleService.GetAllVehicles();
            _memoryCache.Set(VehicleListCacheKey, query,cacheOptions);
            return query;

            

        }

        public Task<Vehicle> GetVehicleById(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> UpdateVehicle(int vehicleId, Vehicle updatedVehicle)
        {
            throw new NotImplementedException();
        }
    }
}
