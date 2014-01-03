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
                        where (h.LocationId == locationId || h.Location.ParentId == locationId ||
                              (h.Location.ParentLocation != null && h.Location.ParentLocation.ParentId == locationId)) &&
                              (hotelTypeId == null || h.HotelTypeId == hotelTypeId.Value)
                        select h;
            return query;
        }
    }
}
