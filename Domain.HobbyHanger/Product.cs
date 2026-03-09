namespace Domain.HobbyHanger;

public abstract class Product
{
    public string ProductId { get; set; } = Guid.NewGuid().ToString();
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required double Price { get; set; }
    public string? Brand { get; set; }
    public DateTime Date { get; set;  }
    public bool IsSold { get; set; }
}