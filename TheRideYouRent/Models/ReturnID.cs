//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheRideYouRent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReturnID
    {
        public string CarNo { get; set; }
        public Nullable<int> Inspector_no { get; set; }
        public Nullable<int> DriverID { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<System.DateTime> ElapsedDate { get; set; }
        public Nullable<int> Fine { get; set; }
        public int ID { get; set; }
    }
}
