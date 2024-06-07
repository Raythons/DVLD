

namespace DLVD.App.Features.Licenses.Query.GetDetainedLicense
{
    public class GetDetainedLicenseInfoResponse
    {
        public int DetainId { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainTime { get; set; }
        public string CreatedByUser { get; set; } = string.Empty;
        public int ApplicationFees { get; set; }
        public float FineFees { get; set; }
    }
}
