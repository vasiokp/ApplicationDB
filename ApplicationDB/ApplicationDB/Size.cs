//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Size
    {
        public Size()
        {
            this.Pizzas = new HashSet<Pizza>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Diameter { get; set; }
        public double Coefficient { get; set; }
    
        public virtual ICollection<Pizza> Pizzas { get; set; }

        
    }
}
