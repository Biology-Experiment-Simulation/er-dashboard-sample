//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERDashboard.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vital
    {
        public int ID { get; set; }
        public Nullable<int> VitalSignTypeID { get; set; }
        public Nullable<int> AdmittanceID { get; set; }
        public string VitalSignValue { get; set; }
        public Nullable<System.DateTime> Timestamp { get; set; }
    
        public virtual Admittance Admittance { get; set; }
        public virtual VitalSignType VitalSignType { get; set; }
    }
}