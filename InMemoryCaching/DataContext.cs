using Bogus;
using InMemoryCaching.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryCaching
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) {}

        public DbSet<Vehicle> Vehicles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //bogus
            var id = 1;
            var vehicles = new Faker<Vehicle>()
                .RuleFor(x => x.Id, x => id++)
                .RuleFor(x => x.Manufacturer, x => x.Vehicle.Manufacturer())
                .RuleFor(x => x.Type, x => x.Vehicle.Type())
                .RuleFor(x => x.Model, x => x.Vehicle.Model())
                .RuleFor(x => x.Vin, x => x.Vehicle.Vin())
                .RuleFor(x => x.Fuel, x => x.Vehicle.Fuel());
            modelBuilder.Entity<Vehicle>().HasData(vehicles.GenerateBetween(500,500));

            
        }
    }
}
