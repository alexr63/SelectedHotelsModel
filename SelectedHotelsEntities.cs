using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectedHotelsModel
{
    public partial class SelectedHotelsEntities
   {
        public IEnumerable<Hotel> HotelsInLocation(int locationId, int? hotelTypeId = null)
        {
            IList<Hotel> hotels = (from p in Products
                                   where !p.IsDeleted
                                   select p).OfType<Hotel>().ToList();
            var query = from h in hotels
                        where (h.HotelLocations.Any(hl => hl.LocationId == locationId)) &&
                              (h.HotelTypeId == hotelTypeId)
                        select h;
            return query;
        }
    }
}
