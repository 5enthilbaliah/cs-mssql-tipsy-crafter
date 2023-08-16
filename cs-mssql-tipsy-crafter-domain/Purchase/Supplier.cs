namespace AmritaDb.Tipsy.Domain.Purchase;

public class Supplier
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? WebsiteUrl { get; set; }
    public string Address1 { get; set; } = null!;
    public string? Address2 { get; set; }
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public string PreferredCurrency { get; set; } = null!;
    
    public ICollection<SupplierContact> Contacts => null!;
    public ICollection<Order> Orders => null!;
}