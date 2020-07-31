using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RSAT.Api.Data.Entities;

namespace RSAT.Api.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasOne(x => x.ActualCheckinStatuse);
            builder.HasMany(x => x.HistoryOfStatuses)
                .WithOne(x => x.EmployeeObject)
                .HasForeignKey(x => x.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.ToTable("Employee");
        }
    }
}
