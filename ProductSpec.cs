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
    
    public partial class ProductSpec
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string DimensionMet { get; set; }
        public string DimensionImp { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
