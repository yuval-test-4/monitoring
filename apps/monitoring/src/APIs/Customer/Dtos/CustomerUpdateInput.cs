namespace Monitoring.APIs.Dtos;

public class CustomerUpdateInput
{
    public string? Address { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? FirstName { get; set; }

    public string? Id { get; set; }

    public List<string>? Orders { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
