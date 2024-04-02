
namespace DVLD.Domain.Entities
{
    public class TestAppointment 
    {
        public int Id { get; set; }
        public int TestTypeId { get; set; }
        public TestType TestType { get; set; }
        public int LocalDrivingLicenseApplicationId { get; set; }
        public LocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserId { get; set; }
        public User User { get; set; }
        public bool IsLocked { get; set; } = false;

        //public int TestId { get; set; }
        public Test? Test { get; set; }
    }
}