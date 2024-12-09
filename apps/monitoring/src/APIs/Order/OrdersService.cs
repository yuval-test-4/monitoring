using Monitoring.Infrastructure;

namespace Monitoring.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(MonitoringDbContext context)
        : base(context) { }
}
