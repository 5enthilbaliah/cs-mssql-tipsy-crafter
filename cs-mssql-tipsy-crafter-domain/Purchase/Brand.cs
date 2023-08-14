namespace AmritaDb.Tipsy.Domain.Purchase;

public class Brand
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? WebsiteUrl { get; set; }
}