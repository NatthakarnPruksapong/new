//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace preproject2MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class status_history
    {
        public string line_id { get; set; }
        public string ad_id { get; set; }
        public System.DateTime s_date { get; set; }
        public short command { get; set; }
        public string s_description { get; set; }
    
        public virtual administrator administrator { get; set; }
        public virtual customer customer { get; set; }
    }
}
