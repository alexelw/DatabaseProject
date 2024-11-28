using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusRoute> Routes { get; set; }
        public DbSet<BusStop> BusStops { get; set; }
        public DbSet<StopSequence> StopSequences { get; set; }
        public DbSet<Road> Roads { get; set; }
        public DbSet<TrafficCondition> TrafficConditions { get; set; }
        public DbSet<Roadwork> Roadworks { get; set; }
        public DbSet<ScheduledJourney> ScheduledJourneys { get; set; }
        public DbSet<BusLocation> BusLocations { get; set; }
        public DbSet<Popularity> Popularities { get; set; }
        public DbSet<Area> Areas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
