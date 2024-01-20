namespace MiniCms.Mvc.Models;

public class OrderViewModel
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Surname { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string Address { get; init; } = string.Empty;
    public string Order { get; set; } = string.Empty;
    public long Count { get; init; }
    public string Notes { get; init; } = string.Empty;
    public bool IsDelivered { get; set; }
}