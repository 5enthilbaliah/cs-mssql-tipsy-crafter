namespace AmritaDb.Tipsy.Domain.Stock;

using Retail;

public class Inventory
{
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public string StoreId { get; set; } = null!;
    public decimal Msrp { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public int QuantityAvailable { get; set; }
    public int MinimumStockLevel { get; set; }
    public int MaximumStockLevel { get; set; }
    public int ReorderPoint { get; set; }
    public int QuantityOnDisplay { get; set; }
    public string? AisleLocation { get; set; } 
    public DateTime LatestRestockDate { get; set; }
    
    public Product Product { get; set; } = null!;
    public Store Store { get; set; } = null!;
}