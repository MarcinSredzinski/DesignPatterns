using BusinessLibrary.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(IOrdersRepository ordersRepository) : ControllerBase
    {

        [HttpGet]
        public async Task<IResult> Get()
        {
            var orders = await ordersRepository.GetOrdersAsync();
            return Results.Ok(orders);
        }
    }
}
