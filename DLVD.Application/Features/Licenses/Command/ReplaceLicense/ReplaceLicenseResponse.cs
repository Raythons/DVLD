using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Command.ReplaceLicense
{
    public record class ReplaceLicenseResponse(int ApplicationId,
                                              int PreviousLicenseId,
                                              int NewLicenseId)
    {
    }
}
