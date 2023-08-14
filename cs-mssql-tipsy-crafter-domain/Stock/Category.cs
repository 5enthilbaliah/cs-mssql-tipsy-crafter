namespace AmritaDb.Tipsy.Domain.Stock;

public class Category
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Slug { get; set; } = null!;
    
    public string? ParentId { get; set; }
    public Category? ParentCategory { get; set; }
    
    public ICollection<Category> Children => null!;
    public ICollection<ProductType> ProductTypes => null!;
}