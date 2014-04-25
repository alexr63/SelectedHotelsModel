//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelectedHotelsModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hotel : Product
    {
        public Hotel()
        {
            this.HotelLocations = new HashSet<HotelLocation>();
        }
    
        public Nullable<int> Rooms { get; set; }
        public Nullable<decimal> Star { get; set; }
        public Nullable<decimal> CustomerRating { get; set; }
        public string Address { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lon { get; set; }
        public string PostCode { get; set; }
        public int HotelTypeId { get; set; }
    
        public virtual HotelType HotelType { get; set; }
        public virtual ICollection<HotelLocation> HotelLocations { get; set; }
    }
}
