using BusinessLibrary.Models;
using DesignPatternsWeb.DB;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController(CustomersUnitOfWork customersUnitOfWork) : Controller
    {
        [HttpPost]
        public async Task<IResult> Customer([FromBody]CustomerDto customer)
        {
            if (customer is not null && customer.Orders.Any())
            {
                var createdCustomer = await customersUnitOfWork.CustomersRepository.CreateCustomerAsync(customer);
                foreach (var order in customer.Orders)
                {
                    await customersUnitOfWork.OrdersRepository.CreateOrderAsync(order);
                }
                customersUnitOfWork.Save();
                return Results.Created($"/customers/{createdCustomer.Id}", createdCustomer);
            }
            return Results.Problem("Failed to create customer");
        }
    }
}
