//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfTheDay_webservice.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quote
    {
        public int id { get; set; }
        public string content { get; set; }
        public string image_url { get; set; }
        public string author { get; set; }
        public Nullable<System.DateTime> created_on { get; set; }
        public Nullable<System.DateTime> upload_on { get; set; }
        public Nullable<bool> is_uploaded { get; set; }
        public Nullable<int> like_counter { get; set; }
    }
}
