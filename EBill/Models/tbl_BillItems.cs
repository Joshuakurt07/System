//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBill.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_BillItems
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> BillId { get; set; }
    
        public virtual tbl_BillDetails tbl_BillDetails { get; set; }
    }
}
