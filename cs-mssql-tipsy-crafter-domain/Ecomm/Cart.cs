namespace AmritaDb.Tipsy.Domain.Ecomm;

using Retail;

public class Cart
{
    public string Id { get; set; } = null!;
    public string CustomerId { get; set; } = null!;

    public Customer Customer { get; set; } = null!;

    public ICollection<CartItem> Items => null!;
}