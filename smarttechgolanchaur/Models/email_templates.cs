//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace smarttechgolanchaur.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class email_templates
    {
        public long id { get; set; }
        public string title { get; set; }
        public string code { get; set; }
        public string subject { get; set; }
        public string template { get; set; }
        public string type { get; set; }
        public string from { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    }
}
