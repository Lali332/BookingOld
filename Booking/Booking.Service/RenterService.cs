using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Service
{
    public class RenterService:IRenterService
    {

        private readonly IRenterRepository _renterRepository;
        public RenterService(IRenterRepository renterRepository)
        {
            _renterRepository = renterRepository;
        }
        public List<Renter> GetAllRenters()
        {
            return _renterRepository.GetAllRenters();
        }
        public Renter GetRenterById(int id)
        {
            return _renterRepository.GetRenterById(id);
        }
        public void DeleteRenter(int id)
        {
            _renterRepository.DeleteRenter(id);
        }
        public void AddRenter(Renter renter)
        {
            _renterRepository.AddRenter(renter);
        }
        public void UpDateRenter(int id,Renter renter)
        {
            _renterRepository.UpDateRenter(id,renter);
        }
    }
}
