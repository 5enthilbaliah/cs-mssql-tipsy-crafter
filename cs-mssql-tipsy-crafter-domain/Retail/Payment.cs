namespace AmritaDb.Tipsy.Domain.Retail;

using Universal;

public class Payment
{
    public string Id { get; set; } = null!;
    public string ReceiptId { get; set; } = null!;
    public string PaymentModeId { get; set; } = null!;
    public string Memo { get; set; } = null!;
    public decimal Amount { get; set; }
    
    public Receipt Receipt { get; set; } = null!; 
    public PaymentMode PaymentMode  { get; set; } = null!; 
}