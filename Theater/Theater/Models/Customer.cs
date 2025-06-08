using System.ComponentModel.DataAnnotations;

namespace Theater.Models;

public class Customer
{
    public int CustomerId { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    [MaxLength(100)]
    public string? PhoneNumber { get; set; }

    public List<PurchasedTicket> PurchasedTickets { get; set; } = null!;
}