using Theater.Models;

namespace Theater.Services;

public interface IDbService
{
    Task<bool> DoesCustomerExist(int id);
    Task AddCustomer(Customer customer);
    Task<Customer?> GetCustomerData(int id);
}