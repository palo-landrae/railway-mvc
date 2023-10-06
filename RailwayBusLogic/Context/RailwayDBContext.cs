using Microsoft.EntityFrameworkCore;
using RailwayBusLogic.Context.DBModel;
using dotenv.net;

namespace RailwayBusLogic.Context
{
  public class RailwayDBContext : DbContext
  {
    public DbSet<DBPassenger> Passengers { get; set; }
    public DbSet<DBStation> Stations { get; set; }
    public DbSet<DBTicket> Ticket { get; set; }
    public DbSet<DBTicketBooking> TicketBookings { get; set; }
    public DbSet<DBTrain> Trains { get; set; }
    public DbSet<DBTrainSchedule> TrainSchedules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[] { "../.env" }));

      string host = Environment.GetEnvironmentVariable("PG_HOST");
      string database = Environment.GetEnvironmentVariable("PG_NAME");
      string port = Environment.GetEnvironmentVariable("PG_PORT");
      string user = Environment.GetEnvironmentVariable("PG_USER");
      string password = Environment.GetEnvironmentVariable("PG_PASSWORD");

      optionsBuilder.UseNpgsql(
          $"Host={host};Port={port};Database={database};Username={user};Password={password}"
      );
    }
  }
}
