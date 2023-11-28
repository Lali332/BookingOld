using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Services
{
    public interface IRenterService
    {
        public List<Renter> GetAllRenters();
        public Renter GetRenterById(int id);
        public void DeleteRenter(int id);
        public void UpDateRenter(int id,Renter r);
        public void AddRenter(Renter r);
    }
}
