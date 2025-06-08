using System.ComponentModel.DataAnnotations;

namespace Theater.Models;

public class Ticket
{
    [Key]
    public int TicketId { get; set; }
    [MaxLength(50)]
    public string Serialnumber { get; set; }
    public int SeatNumber { get; set; }
    
    public List<TicketConcert> TicketConcerts { get; set; } = new List<TicketConcert>();
}