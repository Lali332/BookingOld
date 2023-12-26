using Booking.Core.Entities;
using Booking.Core.Repositories;
using Booking.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data.Repositories
{
    public class RenterRepository:IRenterRepository
    {
        private readonly DataContext _context;
        public RenterRepository(DataContext context)
        {
            _context = context;
        }
        public List<Renter> GetAllRenters()
        {
            return _context.Renters.ToList();
        }
        public Renter GetRenterById(int id)
        {
            return _context.Renters.ToList().Find(o => o.renterId == id);
        }
        public void DeleteRenter(int id)
        {
            var renter = _context.Renters.ToList().Find(o => o.renterId == id);
            _context.Renters.Remove(renter);
        }
        public void UpDateRenter(int id,Renter r)
        {
            var renter = _context.Renters.ToList().Find(e => e.renterId ==id);          
            renter.name = r.name;
            renter.phone = r.phone;
        }
        public void AddRenter(Renter r)
        {
            _context.Renters.Add(new Renter
            { renterId = _context.CntRenters++, 
                name = r.name,
                phone = r.phone });
        }
    }
}
