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
    
    public partial class ThiSinhDK
    {
        public ThiSinhDK()
        {
            this.DSThiSinhTrongPhongThis = new HashSet<DSThiSinhTrongPhongThi>();
        }
    
        public int MADK { get; set; }
        public string CMND { get; set; }
        public System.DateTime NGAYDK { get; set; }
        public string TRINHDO { get; set; }
        public string HOTEN { get; set; }
        public string GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
    
        public virtual ICollection<DSThiSinhTrongPhongThi> DSThiSinhTrongPhongThis { get; set; }
    }
}
