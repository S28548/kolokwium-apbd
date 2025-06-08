using Microsoft.EntityFrameworkCore;
using Theater.Models;

namespace Theater.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }
    
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<PurchasedTicket> PurchasedTickets { get; set; }
    public DbSet<TicketConcert> TicketConcerts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Concert>().HasData(new List<Concert>
        {
            new Concert()
            {
                ConcertId = 1,
                AvailableTickets = 50,
                Date = new DateTime(2020, 01, 01),
                Name = "The Lord of the Rings",
            },
            new Concert()
            {
                ConcertId = 2,
                AvailableTickets = 0,
                Date = new DateTime(2020, 01, 01),
                Name = "The King of the Rings",
            },
            new Concert()
            {
                ConcertId = 3,
                AvailableTickets = 100,
                Date = new DateTime(2020, 01, 01),
                Name = "The Lord of the Rivers",
            }
        });

        modelBuilder.Entity<Customer>().HasData(new List<Customer>
        {
            new Customer()
            {
                CustomerId = 1,
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "08888888888",
            },
            new Customer()
            {
                CustomerId = 2,
                FirstName = "Jane",
                LastName = "Doe",
                PhoneNumber = "08855588",
            },
            new Customer()
            {
                CustomerId = 3,
                FirstName = "John",
                LastName = "Pork",
                PhoneNumber = "0999999",
            },
        });

        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>
        {
            new Ticket()
            {
                TicketId = 1,
                SeatNumber = 2,
                Serialnumber = "fsdfgdgf",
            },
            new Ticket()
            {
                TicketId = 2,
                SeatNumber = 4,
                Serialnumber = "fgdhdhgf",
            },
            new Ticket()
            {
                TicketId = 3,
                SeatNumber = 7,
                Serialnumber = "hjghgkhg",
            },
        });

        modelBuilder.Entity<TicketConcert>().HasData(new List<TicketConcert>
        {
            new TicketConcert()
            {
                TicketConcertId = 1,
                TicketId = 1,
                ConcertId = 1,
                Price = 10,
            },
            new TicketConcert()
            {
                TicketConcertId = 2,
                TicketId = 2,
                ConcertId = 1,
                Price = 10,
            },
            new TicketConcert()
            {
                TicketConcertId = 3,
                TicketId = 3,
                ConcertId = 2,
                Price = 100,
            },
        });
        
        modelBuilder.Entity<PurchasedTicket>().HasData(new List<PurchasedTicket>
        {
            new PurchasedTicket()
            {
                TicketConcertId = 1,
                CustomerId = 1,
                PurchaseDate = DateTime.Now,
            },
            new PurchasedTicket()
            {
                TicketConcertId = 2,
                CustomerId = 3,
                PurchaseDate = DateTime.Now,
            },
            new PurchasedTicket()
            {
                TicketConcertId = 3,
                CustomerId = 2,
                PurchaseDate = DateTime.Now,
            },
        });
    }
}