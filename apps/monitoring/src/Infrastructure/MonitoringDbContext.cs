using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monitoring.Infrastructure.Models;

namespace Monitoring.Infrastructure;

public class MonitoringDbContext : IdentityDbContext<IdentityUser>
{
    public MonitoringDbContext(DbContextOptions<MonitoringDbContext> options)
        : base(options) { }

    public DbSet<CustomerDbModel> Customers { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }
}
