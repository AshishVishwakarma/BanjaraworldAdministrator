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
    using System.ComponentModel.DataAnnotations;
    
    public partial class tbl_Gallery
    {
        public int glr_ID { get; set; }

        [StringLength(100)]
        public string glr_Image { get; set; }

        [StringLength(25)]
        public string glr_Description { get; set; }

        [StringLength(25)]
        public string glr_Type { get; set; }
        public Nullable<int> glr_PlaceID { get; set; }
        public Nullable<int> glr_PackageID { get; set; }
    
        public virtual tbl_Package tbl_Package { get; set; }
        public virtual tbl_Place tbl_Place { get; set; }
    }
}
