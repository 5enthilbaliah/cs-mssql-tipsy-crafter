namespace AmritaDb.Tipsy.Domain.Stock;

public class ProductImage
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string ProductId { get; set; } = null!;
    public string ModifiedBy { get; set; } = null!;
    
    public Product Product { get; set; } = null!;
}