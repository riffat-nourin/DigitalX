//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalX.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Reviews
    {
        public long ProductID { get; set; }
        public long CustomerID { get; set; }
        public string Review { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
