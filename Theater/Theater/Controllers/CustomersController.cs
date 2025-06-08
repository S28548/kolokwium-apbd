using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using Theater.DTOs;
using Theater.Models;
using Theater.Services;

namespace Theater.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly IDbService _dbService;
    public CustomersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{customerId}/purchases")]
    public async Task<IActionResult> GetCustomerOrders(int customerId)
    {
        var customer = await _dbService.GetCustomerData(customerId);
        if (customer is null)
        {
            return NotFound("Customer not found");
        }

        var purchase = new PurchaseDto()
        {
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            PhoneNumber = customer.PhoneNumber,
            // Purchases = 
        };
        
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> AddNewCustomerWithTickets(CustomerInfoDto customerInfoDto)
    {
        try
        {
            if (!await _dbService.DoesCustomerExist(customerInfoDto.CustomerDto.Id))
                return NotFound($"Customer with given ID - {customerInfoDto.CustomerDto.Id} doesn't exist");

            if (customerInfoDto.PurchaseDtos.Count > 5)
            {
                return BadRequest("Too many tickets");
            }
            
            var customer = new Customer()
            {
                CustomerId = customerInfoDto.CustomerDto.Id,
                FirstName = customerInfoDto.CustomerDto.FirstName,
                LastName = customerInfoDto.CustomerDto.LastName,
                PhoneNumber = customerInfoDto.CustomerDto.PhoneNumber,
            };
            
            await _dbService.AddCustomer(customer);
            

            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}