//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cascading_dropdown.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Docter_tbl
    {
        public int doc_ID { get; set; }
        public string doc_Name { get; set; }
        public string doc_Spec { get; set; }
        public Nullable<int> des_fk_ID { get; set; }
    
        public virtual disease_tbl disease_tbl { get; set; }
    }
}
