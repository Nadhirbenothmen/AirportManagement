using AM.ApplicationCore.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMInfraStructure.Configuration
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane> 
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey (p=> p.PlaneId); //PlaneId clé primaire DB 
            builder.ToTable("Myplanes"); //naatiw nom lel entité fe DB
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity");
        }
    }
}
