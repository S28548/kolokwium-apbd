using Microsoft.EntityFrameworkCore;
using Theater.Data;
using Theater.Models;

namespace Theater.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<bool> DoesCustomerExist(int id)
    {
        return await _context.Customers.AnyAsync(e => e.CustomerId == id);
    }

    public async Task AddCustomer(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
    }
    
    public async Task<Customer?> GetCustomerData(int id)
    {
        return await _context.Customers.FirstOrDefaultAsync(e => e.CustomerId == id);
    }
    
    // public async Task<ICollection<>>
    
    // public async Task AddCustomerWithTickets(Order order)
    // {
    //     await _context.AddAsync(order);
    //     await _context.SaveChangesAsync();
    // }
}