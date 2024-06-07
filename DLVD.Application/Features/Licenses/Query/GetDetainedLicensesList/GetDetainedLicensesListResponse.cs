

namespace DLVD.App.Features.Licenses.Query.GetDetainedLicensesList
{
    public  record class GetDetainedLicensesListResponse (
                                    int DetainId,
                                    int DetainedLicenseId,
                                    bool IsReleased,
                                    float FineFees,
                                    DateTime ReleaseDate,
                                    string NationalNo,
                                    string FullName,
                                    int ReleaseAppId)
    {

    }
}
