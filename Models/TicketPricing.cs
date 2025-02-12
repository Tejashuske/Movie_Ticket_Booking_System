using System;
using System.Collections.Generic;

namespace Movie_Ticket_Booking_System.Models;

public partial class TicketPricing
{
    public int PricingId { get; set; }

    public int? MovieId { get; set; }

    public decimal Price { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Movie? Movie { get; set; }
}
