#pragma warning disable CS8618


namespace DVLD.Domain.Entities;

public class TestType 
{
    public int Id { get; set; }
    public string TestTypeTitle { get; set;}
    public string TestTypeDescription { get; set; }
    public float TestTypeFees { get; set; }
    public ICollection<TestAppointment>? TestAppointments { get; set; }
}
