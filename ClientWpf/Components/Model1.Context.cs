﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWpf.Components
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kersachViEntities : DbContext
    {
        public kersachViEntities()
            : base("name=kersachViEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CookingStage> CookingStage { get; set; }
        public virtual DbSet<CountryOrigin> CountryOrigin { get; set; }
        public virtual DbSet<CountryOriginDish> CountryOriginDish { get; set; }
        public virtual DbSet<DegreeSharpness> DegreeSharpness { get; set; }
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<IngredientOfCookingSage> IngredientOfCookingSage { get; set; }
        public virtual DbSet<Landing> Landing { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDish> OrderDish { get; set; }
        public virtual DbSet<Otdel> Otdel { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<Сlient> Сlient { get; set; }
    }
}
