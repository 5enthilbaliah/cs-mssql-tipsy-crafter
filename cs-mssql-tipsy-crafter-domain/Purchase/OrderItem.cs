namespace AmritaDb.Tipsy.Domain.Purchase;

using Stock;

public class OrderItem
{
    public string Id { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public string OrderId { get; set; } = null!;
    public string? DeliveryId { get; set; }
    public int NoOfUnits { get; set; }
    public string DiscountCurrency { get; set; } = null!;
    public decimal Discount { get; set; }
    public string CostCurrency { get; set; } = null!;
    public decimal Cost { get; set; }
    public string TotalCurrency { get; set; } = null!;
    public decimal Total { get; set; }
    public decimal StoreTotal { get; set; }
    public string ModifiedBy { get; set; } = null!;

    public Product Product { get; set; } = null!;
    public Order Order { get; set; } = null!;
    public Delivery? Delivery { get; set; }
}