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
    
    public partial class country
    {
        public country()
        {
            this.link_country_website = new HashSet<link_country_website>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<link_country_website> link_country_website { get; set; }
    }
}
