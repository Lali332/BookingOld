using Booking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core.Repositories
{
    public interface IZimmerRepository
    {
        public List<Zimmer> GetAllZimmers();
        public Zimmer GetZimmerById(int id);
        public void DeleteZimmer(int id);
        public void UpDateZimmer(int id, Zimmer z);
        public void AddZimmer(Zimmer z);
    }
}
