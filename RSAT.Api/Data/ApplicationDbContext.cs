using Microsoft.EntityFrameworkCore;
using RSAT.Api.Data.Configurations;
using RSAT.Api.Data.Entities;


namespace RSAT.Api.Data
{
    public class ApplicationDbContext : NovusConsulting.Data.SqlServer.ApplicationDbContext
    {
        public ApplicationDbContext(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Employee> Employee { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }

}
