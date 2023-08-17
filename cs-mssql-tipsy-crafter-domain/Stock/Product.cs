namespace AmritaDb.Tipsy.Domain.Stock;

using Purchase;

public class Product
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Sku { get; set; } = null!;
    public string Upc { get; set; } = null!;
    public string ProductTypeId { get; set; } = null!;
    
    public ProductType ProductType { get; set; } = null!;

    public ICollection<ProductImage> ProductImages => null!;
    public ICollection<OrderItem> OrderItems => null!;
}