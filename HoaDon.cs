//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM_PBL3
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public int MaHD { get; set; }
        public int ID { get; set; }
        public int MaKH { get; set; }
        public System.DateTime NgayBan { get; set; }
    
        public virtual ChiTietHoaDon ChiTietHoaDon { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        // hii
    }
}
