//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaveWorldDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class invoice
    {
        public int id { get; set; }
        public int invoiceNo { get; set; }
        public System.DateTime paymentDate { get; set; }
        public double amount { get; set; }
        public Nullable<int> orderId { get; set; }
    
        public virtual tbOrder tbOrder { get; set; }
    }
}
