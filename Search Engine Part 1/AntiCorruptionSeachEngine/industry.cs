//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntiCorruptionSeachEngine
{
    using System;
    using System.Collections.Generic;
    
    public partial class industry
    {
        public industry()
        {
            this.link_industry_website = new HashSet<link_industry_website>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string keywords { get; set; }
    
        public virtual ICollection<link_industry_website> link_industry_website { get; set; }
    }
}
