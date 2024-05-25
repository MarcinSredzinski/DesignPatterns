using BusinessLibrary.Models;

namespace BusinessLibrary.Repositories;

public interface ICustomersRepository
{
    Task<CustomerDto> CreateCustomerAsync(CustomerDto customer);
    Task DeleteCustomerAsync(int id);
    Task<CustomerDto> GetCustomerByIdAsync(int id);
    Task<IEnumerable<CustomerDto>> GetCustomersAsync();
    Task<CustomerDto> UpdateCustomerAsync(CustomerDto customer);
}
