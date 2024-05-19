using AM.ApplicationCore.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMInfraStructure.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>

    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.FlightFK, t.PassengerFK });
        }
    }
}
