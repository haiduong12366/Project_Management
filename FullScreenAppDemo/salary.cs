//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FullScreenAppDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class salary
    {
        public int id { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<double> basicSalary { get; set; }
        public Nullable<double> totalHours { get; set; }
        public Nullable<double> overtimeHours { get; set; }
        public Nullable<double> leaveHours { get; set; }
        public Nullable<double> bonus { get; set; }
        public Nullable<double> allowance { get; set; }
        public Nullable<double> tax { get; set; }
        public Nullable<double> insurance { get; set; }
        public Nullable<double> finalSalary { get; set; }
        public Nullable<System.DateTime> fromDate { get; set; }
        public Nullable<System.DateTime> toDate { get; set; }
    
        public virtual user user { get; set; }
    }
}
