namespace AmritaDb.Tipsy.Domain.Retail;

using Ecomm;

public class Customer
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Address1 { get; set; } = null!;
    public string? Address2 { get; set; }
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public string ModifiedBy { get; set; } = null!;

    public Cart? Cart { get; set; }
    
    public ICollection<CustomerContact> Contacts => null!;
    public ICollection<Receipt> Receipts => null!;
}