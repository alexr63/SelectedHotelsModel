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
    
    public partial class GeoName
    {
        public GeoName()
        {
            this.Hotels = new HashSet<Hotel>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string FeatureClass { get; set; }
        public string FeatureCode { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public long Population { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
    
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
