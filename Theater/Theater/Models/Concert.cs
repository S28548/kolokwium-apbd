using System.ComponentModel.DataAnnotations;

namespace Theater.Models;

public class Concert
{
    [Key]
    public int ConcertId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    public DateTime Date { get; set; }
    public int AvailableTickets { get; set; }
    
    public List<TicketConcert> TicketConcerts { get; set; } = new List<TicketConcert>();
}