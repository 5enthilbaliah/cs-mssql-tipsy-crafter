namespace AmritaDb.Tipsy.Domain.Retail;

using Universal;

public class Shipment
{
    public string Id { get; set; } = null!;
    public string ReceiptId { get; set; } = null!;
    public string? ShipperId { get; set; }
    public DateTime Date { get; set; }
    public string? TrackingId { get; set; }
    public bool IsDelivered { get; set; }
    
    public Receipt Receipt { get; set; } = null!;
    public Shipper? Shipper { get; set; }
}