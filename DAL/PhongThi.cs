//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhongThi
    {
        public PhongThi()
        {
            this.DSGVTrongPhongThis = new HashSet<DSGVTrongPhongThi>();
            this.DSThiSinhTrongPhongThis = new HashSet<DSThiSinhTrongPhongThi>();
        }
    
        public string MAPHONGTHI { get; set; }
        public string MAKHOATHI { get; set; }
    
        public virtual ICollection<DSGVTrongPhongThi> DSGVTrongPhongThis { get; set; }
        public virtual ICollection<DSThiSinhTrongPhongThi> DSThiSinhTrongPhongThis { get; set; }
        public virtual KhoaThi KhoaThi { get; set; }
    }
}