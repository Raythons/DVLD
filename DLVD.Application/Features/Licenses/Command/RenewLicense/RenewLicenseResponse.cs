﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Command.RenewLicense
{
     public record class RenewLicenseResponse(int ApplicationId,
                                              int PreviousLicenseId,
                                              int NewLicenseId)
    {
    }
}
