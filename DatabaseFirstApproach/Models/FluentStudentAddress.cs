//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstApproach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FluentStudentAddress
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int FluentStudentId { get; set; }
        public int ID { get; set; }
    
        public virtual FluentStudent FluentStudent { get; set; }
    }
}