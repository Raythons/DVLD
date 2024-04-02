using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence
{
    public interface ILicenseClassRepositry
    {
        public Task<IEnumerable<LicenseClass>> All();
        public Task<LicenseClass?> GetById(int LicenseClassId);
   
        public Task<bool> Add(LicenseClass entity);
        public Task<bool> Update(Application entity);
        public Task<bool> Update(int LicenseClassId);
        public Task<bool> Delete(LicenseClass entity);
        public Task<bool> DeleteById(int LicenseClassId);
        public Task<IEnumerable<LocalDrivingLicenseApplication>> GetAssociatedLocalDrivingLicenseApplications();
        public Task<IEnumerable<License>> GetAssociatedLicenses(int LicenseClassId);

    }
}
