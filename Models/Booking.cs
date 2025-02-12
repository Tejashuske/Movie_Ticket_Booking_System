using System;
using System.Collections.Generic;

namespace Movie_Ticket_Booking_System.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? UserId { get; set; }

    public int? MovieId { get; set; }

    public string SeatNumber { get; set; } = null!;

    public DateTime? BookingDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Movie? Movie { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual User? User { get; set; }
}
