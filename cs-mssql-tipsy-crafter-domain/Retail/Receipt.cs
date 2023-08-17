namespace AmritaDb.Tipsy.Domain.Retail;

public class Receipt
{
    public string Id { get; set; } = null!;
    public string CustomerId { get; set; } = null!;
    public string StoreId { get; set; } = null!;
    public DateTime Date { get; set; }
    public string StatusId { get; set; } = null!;
    public decimal SubTotal { get; set; }
    public decimal Tax { get; set; }
    public decimal Shipping { get; set; }
    public decimal Total { get; set; }
    public decimal ItemDiscount { get; set; }
    public decimal Discount { get; set; }
    public decimal GrandTotal { get; set; }
    public string CustomerGrandTotalCurrency { get; set; } = null!;
    public decimal CustomerGrandTotal { get; set; }
    public string? PromoCode { get; set; }
    public string ModifiedBy { get; set; } = null!;
    
    public Customer Customer { get; set; } = null!;
    public Store Store { get; set; } = null!;
    public SaleStatus Status { get; set; } = null!;
}