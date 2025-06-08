namespace Theater.DTOs;

public class CustomerInfoDto
{
    public CustomerDto CustomerDto { get; set; }
    public List<PurchaseDto> PurchaseDtos { get; set; }
}

public class CustomerDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
}

public class PurchaseInfoDto
{
    public int SeatNumber { get; set; }
    public string ConcertName { get; set; } = null!;
    public decimal Price { get; set; }
}