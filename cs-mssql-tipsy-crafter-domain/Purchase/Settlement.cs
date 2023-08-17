namespace AmritaDb.Tipsy.Domain.Purchase;

using Universal;

public class Settlement
{
    public string Id { get; set; } = null!;
    public string OrderId { get; set; } = null!;
    public string PaymentModeId { get; set; } = null!;
    public string Memo { get; set; } = null!;
    public string PaidCurrency { get; set; } = null!;
    public decimal Paid { get; set; }
    
    public Order Order { get; set; } = null!; 
    public PaymentMode PaymentMode  { get; set; } = null!; 
}