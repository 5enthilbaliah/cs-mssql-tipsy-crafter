namespace AmritaDb.Tipsy.Domain.Retail;

using Stock;

public class ReceiptLine
{
    public string Id { get; set; } = null!;
    public string InventoryId { get; set; } = null!;
    public string ReceiptId { get; set; } = null!;
    public string? ShipmentId { get; set; }
    public int Quantity { get; set; }
    public decimal Discount { get; set; }
    public decimal Msrp { get; set; }
    public decimal Total { get; set; }
    public string ModifiedBy { get; set; } = null!;
    
    public Inventory Inventory { get; set; } = null!;
    public Receipt Receipt { get; set; } = null!; 
    public Shipment Shipment { get; set; } = null!;
}