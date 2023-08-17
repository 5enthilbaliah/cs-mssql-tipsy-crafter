namespace AmritaDb.Tipsy.Domain.Purchase;

using Retail;

public class Order
{
    public string Id { get; set; } = null!;
    public string ExternalId { get; set; } = null!;
    public string SupplierId { get; set; } = null!;
    public string StoreId { get; set; } = null!;
    public DateTime Date { get; set; }
    public string StatusId { get; set; } = null!;
    public string SubTotalCurrency { get; set; } = null!;
    public decimal SubTotal { get; set; }
    public string ItemDiscountCurrency { get; set; } = null!;
    public decimal ItemDiscount { get; set; }
    public string TaxCurrency { get; set; } = null!;
    public decimal Tax { get; set; }
    public string ShippingCurrency { get; set; } = null!;
    public decimal Shipping { get; set; }
    public string TotalCurrency { get; set; } = null!;
    public decimal Total { get; set; }
    public string DiscountCurrency { get; set; } = null!;
    public decimal Discount { get; set; }
    public string GrandTotalCurrency { get; set; } = null!;
    public decimal GrandTotal { get; set; }
    public decimal StoreGrandTotal { get; set; }
    public string? PromoCode { get; set; }
    public DateTime? ExpectedDate { get; set; }
    public string ModifiedBy { get; set; } = null!;
    
    public Supplier Supplier { get; set; } = null!;
    public Store Store { get; set; } = null!;
    public OrderStatus Status { get; set; } = null!;

    public ICollection<Delivery> Deliveries => null!;
    public ICollection<OrderItem> Items => null!;
}