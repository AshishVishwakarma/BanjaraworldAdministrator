//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BW_Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_FeaturedPackage
    {
        public int ftp_ID { get; set; }
        public Nullable<int> ftp_PlaceFK { get; set; }
        public Nullable<int> ftp_Priority { get; set; }
    
        public virtual tbl_Package tbl_Package { get; set; }
    }
}
