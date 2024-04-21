#pragma warning disable CS8618


namespace DVLD.Domain.Entities;
public class Country 
{
    public int Id { get; set; }
    public string CountryName { get; set; }
    public Person? Person { get; set; }
}
#pragma warning restore CS8618
