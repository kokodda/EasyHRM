//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeeHRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttEmployeeLog
    {
        public long LogId { get; set; }
        public Nullable<int> logEmpCode { get; set; }
        public Nullable<System.DateTime> logDate { get; set; }
        public Nullable<System.TimeSpan> logTime { get; set; }
        public string logIpAddress { get; set; }
        public Nullable<int> logTypeID { get; set; }
        public Nullable<int> logMethodId { get; set; }
    }
}