namespace AmritaDb.Tipsy.Domain.Stock;

public class ProductType
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string CategoryId { get; set; } = null!;
    
    public Category Category { get; set; } = null!;
    public ICollection<Product> Products => null!;
}