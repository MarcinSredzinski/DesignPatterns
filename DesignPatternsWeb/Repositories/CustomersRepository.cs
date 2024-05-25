using BusinessLibrary.Models;
using BusinessLibrary.Repositories;
using DesignPatternsWeb.DB;

namespace DesignPatternsWeb.Repositories;

public class CustomersRepository(InMemeoryDBContext context) : ICustomersRepository
{
    public async Task<CustomerDto> CreateCustomerAsync(CustomerDto customer)
    {
        var created = await context.Customers.AddAsync(customer);
        return created.Entity;
    }

    public Task DeleteCustomerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDto> GetCustomerByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomerDto>> GetCustomersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDto> UpdateCustomerAsync(CustomerDto customer)
    {
        throw new NotImplementedException();
    }
}