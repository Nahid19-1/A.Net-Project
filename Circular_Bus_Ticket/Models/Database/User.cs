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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.SoldTickets = new HashSet<SoldTicket>();
        }
    
        public int U_Id { get; set; }
        public string U_UserName { get; set; }
        public string U_Password { get; set; }
        public string U_Phone { get; set; }
        public string U_Email { get; set; }
        public string U_Address { get; set; }
        public string U_Gender { get; set; }
        public string U_DateofBirth { get; set; }
        public string U_Role { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoldTicket> SoldTickets { get; set; }
    }
}