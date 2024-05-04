using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Domain.Entities.Views
{
    public class DriversBreifInfoView
    {
        public int DriverId { get; set; }
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int NumberOfActiveLicenses { get; set; }
    }
}
