//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Circular_Bus_Ticket.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusRoute
    {
        public int BR_Id { get; set; }
        public Nullable<int> BR_BId { get; set; }
        public string BR_Start { get; set; }
        public string BR_End { get; set; }
        public string BR_Stopage1 { get; set; }
        public string BR_Stopage2 { get; set; }
        public string BR_Stopage3 { get; set; }
        public string BR_Time { get; set; }
        public Nullable<int> BR_FairInS1 { get; set; }
        public Nullable<int> BR_FairInS2 { get; set; }
        public Nullable<int> BR_FairInS3 { get; set; }
    
        public virtual BusInfo BusInfo { get; set; }
    }
}
