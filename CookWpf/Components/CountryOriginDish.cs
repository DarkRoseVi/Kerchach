//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CookWpf.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class CountryOriginDish
    {
        public int Id { get; set; }
        public Nullable<int> CountryOriginId { get; set; }
        public Nullable<int> DishId { get; set; }
    
        public virtual CountryOrigin CountryOrigin { get; set; }
        public virtual Dish Dish { get; set; }
    }
}
