﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SP23.P03.Web.Features.Tickets
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(x => x.train_Id)
                .IsRequired();

            builder.Property(x => x.ticketPrice)
                .IsRequired();

            builder.Property(x => x.bookingDate)
                .IsRequired();

            builder.Property(x => x.seatType)
                .HasMaxLength(120)
                .IsRequired();
        }
    }
}