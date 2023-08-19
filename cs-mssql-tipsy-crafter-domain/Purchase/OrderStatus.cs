namespace AmritaDb.Tipsy.Domain.Purchase;

public class OrderStatus
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ModifiedBy { get; set; } = null!;
    
    public ICollection<Order> Orders => null!;
}