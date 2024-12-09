using Microsoft.AspNetCore.Mvc;

namespace Monitoring.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
