//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daily_Accountant_Api
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvestmentDetail
    {
        public int Id { get; set; }
        public int registerId { get; set; }
        public int Investment_Id { get; set; }
    
        public virtual InvestmentNameId InvestmentNameId { get; set; }
        public virtual User User { get; set; }
    }
}
