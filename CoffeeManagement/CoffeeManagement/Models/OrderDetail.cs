//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int OID { get; set; }
        public int PID { get; set; }
        public Nullable<double> Price { get; set; }
        public int Quatity { get; set; }
        public Nullable<double> Total { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual ShopOrder ShopOrder { get; set; }
    }
}
