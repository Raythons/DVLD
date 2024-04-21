#pragma warning disable CS8618

namespace DVLD.Domain.Entities;

public class Test 
{
    
    public int Id { get; set; }
    public int TestAppointmentId { get; set; }
    public TestAppointment TestAppointment { get; set; }
    public EnTestResult TestResult { get; set; }
    public string Notes { get; set; }
    public int CreatedByUserId { get; set; }
    public User User { get; set; }
}
