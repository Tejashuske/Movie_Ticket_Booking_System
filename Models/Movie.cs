using System;
using System.Collections.Generic;

namespace Movie_Ticket_Booking_System.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public string Title { get; set; } = null!;

    public string? Genre { get; set; }

    public int Duration { get; set; }

    public DateTime ScreeningTime { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<TicketPricing> TicketPricings { get; set; } = new List<TicketPricing>();
}
