namespace AmritaDb.Tipsy.Domain.Universal;

public class Country
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string IsoCode { get; set; } = null!;
    public string? Iso3Code { get; set; }
    public short? NumericCode { get; set; }
    public short PhoneCode { get; set; }
    public string CurrencyCode { get; set; } = null!;
    
    public ICollection<State> States => null!;
}