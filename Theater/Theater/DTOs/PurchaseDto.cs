namespace Theater.DTOs;

public class PurchaseDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public ICollection<ClientPurchaseDto> Purchases { get; set; } = new List<ClientPurchaseDto>();
}

public class ClientPurchaseDto
{
    public string Date { get; set; } = null!;
    public decimal Price { get; set; }
    public TicketDto Ticket { get; set; } = null!;
    public ConcertDto Concert { get; set; } = null!;
}

public class TicketDto
{
    public string Serial { get; set; } = null!;
    public int SeatNumber { get; set; }
}

public class ConcertDto
{
    public string Name { get; set; } = null!;
    public string Date { get; set; } = null!;
}