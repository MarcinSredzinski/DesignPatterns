using BusinessLibrary.Models;

namespace BusinessLibrary.Repositories;

public interface IOrdersRepository
{
    Task<OrderDto> CreateOrderAsync(OrderDto order);
    Task DeleteOrderAsync(int id);
    Task<OrderDto> GetOrderByIdAsync(int id);
    Task<IEnumerable<OrderDto>> GetOrdersAsync();
    Task<OrderDto> UpdateOrderAsync(OrderDto order);
}