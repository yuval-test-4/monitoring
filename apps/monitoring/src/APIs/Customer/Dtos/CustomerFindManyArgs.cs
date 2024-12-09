using Microsoft.AspNetCore.Mvc;
using Monitoring.APIs.Common;
using Monitoring.Infrastructure.Models;

namespace Monitoring.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
