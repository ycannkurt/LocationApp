//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocationApp.Data.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class campussite
    {
        public int CampusSiteID { get; set; }
        public Nullable<int> SiteID { get; set; }
        public Nullable<int> CampusID { get; set; }
        public string Other { get; set; }
    
        public virtual campu campu { get; set; }
        public virtual site site { get; set; }
    }
}
