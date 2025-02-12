using System;
using System.Collections.Generic;

namespace Movie_Ticket_Booking_System.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? BookingId { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string PaymentStatus { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public virtual Booking? Booking { get; set; }
}
