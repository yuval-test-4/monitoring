using Microsoft.AspNetCore.Mvc;

namespace Monitoring.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
