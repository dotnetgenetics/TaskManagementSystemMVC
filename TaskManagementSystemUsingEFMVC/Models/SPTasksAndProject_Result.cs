//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManagementSystemUsingEFMVC.Models
{
    using System;
    
    public partial class SPTasksAndProject_Result
    {
        public int TaskID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskDuration { get; set; }
        public string ProjectName { get; set; }
    }
}