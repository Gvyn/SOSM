//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOSM1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Baskets
    {
        public long UserID { get; set; }
        public long ProductID { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public long BasketID { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Users Users { get; set; }
    }
}