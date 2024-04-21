﻿using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.App.Interfaces.Persistence
{
    public interface IInternationalDrivingLicenseRepositry
    {
        public Task<IEnumerable<InternationalDrivingLicense>> All();
        public Task<InternationalDrivingLicense?> GetById(int id);
        public Task<bool> Add(InternationalDrivingLicense entity);
        public Task<bool> Update(InternationalDrivingLicense entity);
        public Task<bool> Update(int driverId);
        public Task<bool> Delete(InternationalDrivingLicense entity);
        public Task<bool> DeleteById(int id);
        public Task<License> GetRasiedByLicense(int id);
        public Task<InternationalDrivingLicense?> GetInternationalDrivingLicenseApplication(int applicatonId);

        public Task<User> GetCreatedByUser(int id);
        public Task<Driver> GetDriverData(int id);
    }
}
