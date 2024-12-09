using Monitoring.Infrastructure;

namespace Monitoring.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(MonitoringDbContext context)
        : base(context) { }
}
