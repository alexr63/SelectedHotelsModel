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
    
    public partial class TabHotel
    {
        public int Id { get; set; }
        public int TabId { get; set; }
        public int HotelId { get; set; }
        public double Distance { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
