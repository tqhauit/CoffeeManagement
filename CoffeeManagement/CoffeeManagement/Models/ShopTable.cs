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
    
    public partial class ShopTable
    {
        public int TID { get; set; }
        public Nullable<int> OID { get; set; }
        public string Status { get; set; }
    
        public virtual ShopOrder ShopOrder { get; set; }
    }
}
