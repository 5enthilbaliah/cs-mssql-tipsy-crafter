namespace AmritaDb.Tipsy.Domain.Ecomm;

using Stock;

public class CartItem
{
    public string Id { get; set; } = null!;
    public string CartId { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal Msrp { get; set; }
    
    public Cart Cart { get; set; } = null!;
    public Product Product { get; set; } = null!;
}