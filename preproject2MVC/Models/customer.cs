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
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.order_list = new HashSet<order_list>();
            this.status_history = new HashSet<status_history>();
        }
    
        public string line_id { get; set; }
        public string u_name { get; set; }
        public string u_lastname { get; set; }
        public Nullable<short> u_status { get; set; }
        public string u_tel { get; set; }
        public string house_no { get; set; }
        public string village { get; set; }
        public string lane { get; set; }
        public string road { get; set; }
        public string subarea { get; set; }
        public string area { get; set; }
        public string province { get; set; }
        public string postal_code { get; set; }
        public string annotation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_list> order_list { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<status_history> status_history { get; set; }
    }
}
