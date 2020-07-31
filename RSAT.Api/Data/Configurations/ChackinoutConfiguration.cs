using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RSAT.Api.Data.Entities;

namespace RSAT.Api.Data.Configurations
{
    public class CheckInOutConfiguration : IEntityTypeConfiguration<Checkinout>
    {
        public void Configure(EntityTypeBuilder<Checkinout> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasOne(x => x.EmployeeObject);
            builder.ToTable("Checkinout");
        }
    }
}
