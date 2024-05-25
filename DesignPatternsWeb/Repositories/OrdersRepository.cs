using BusinessLibrary.Models;
using BusinessLibrary.Repositories;
using DesignPatternsWeb.DB;
using Microsoft.EntityFrameworkCore;

namespace DesignPatternsWeb.Repositories;

public class OrdersRepository(InMemeoryDBContext context) : IOrdersRepository
{
    public async Task<OrderDto> CreateOrderAsync(OrderDto order)
    {
        var added = await context.Orders.AddAsync(order);
        return added.Entity;
    }

    public async Task<IEnumerable<OrderDto>> GetOrdersAsync()
    {
        return await context.Orders.ToListAsync();
    }

    public Task DeleteOrderAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> GetOrderByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
    public Task<OrderDto> UpdateOrderAsync(OrderDto order)
    {
        throw new NotImplementedException();
    }
}
