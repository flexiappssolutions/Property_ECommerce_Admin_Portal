//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PE_Admin_Library.ModelLibrary.EntityFrameworkLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public long ID { get; set; }
        public string Lastname { get; set; }
        public string Othernames { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> FirstTime { get; set; }
        public Nullable<long> Role { get; set; }
        public Nullable<long> Branch { get; set; }
        public string Status { get; set; }
    }
}
