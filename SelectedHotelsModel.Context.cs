﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SelectedHotelsEntities : DbContext
    {
        public SelectedHotelsEntities()
            : base("name=SelectedHotelsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Feed> Feeds { get; set; }
        public virtual DbSet<HotelType> HotelTypes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductSpec> ProductSpecs { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<HotelLocation> HotelLocations { get; set; }
        public virtual DbSet<ClothSize> ClothSizes { get; set; }
    }
}
