namespace AmritaDb.Tipsy.Domain.Purchase;

using Universal;

public class Delivery
{
    public string Id { get; set; } = null!;
    public string ExternalId { get; set; } = null!;
    public string OrderId { get; set; } = null!;
    public string? ShipperId { get; set; }
    public DateTime Date { get; set; }
    public string? TrackingId { get; set; }
    public bool IsDelivered { get; set; }
    public string ModifiedBy { get; set; } = null!;
    
    public Order Order { get; set; } = null!;
    public Shipper? Shipper { get; set; }
    
    public ICollection<OrderItem> OrderItems => null!;
}