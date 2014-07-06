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
            var query =
                HotelLocations.Where(
                    hl =>
                        hl.LocationId == locationId &&
                        (hotelTypeId == null || hl.HotelTypeId == hotelTypeId) &&
                        !hl.Hotel.IsDeleted)
                    .Select(hl => hl.Hotel);
            return query;
        }
        public IEnumerable<Hotel> HotelsInGeoLocation(int locationId, int? hotelTypeId = null)
        {
            var query =
                HotelLocations.Where(
                    hl =>
                        hl.LocationId == locationId &&
                        (hotelTypeId == null || hl.HotelTypeId == hotelTypeId) &&
                        !hl.Hotel.IsDeleted)
                    .Select(hl => hl.Hotel);
            return query;
        }
   }
}
