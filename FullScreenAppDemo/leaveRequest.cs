//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class leaveRequest
    {
        public int id { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<System.DateTime> requestDate { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<int> numberDay { get; set; }
        public string content { get; set; }
        public string status { get; set; }
        public Nullable<int> idApprover { get; set; }
    
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
