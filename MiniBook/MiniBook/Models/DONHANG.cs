//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniBook.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            this.CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
        }
    
        public int IDDonHang { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<double> TongTien { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
        public string DiaChiNhan { get; set; }
        public string SDTNhan { get; set; }
        public string TenNguoiNhan { get; set; }
        public Nullable<System.DateTime> NgayGuiHang { get; set; }
        public string HTGiaoHang { get; set; }
        public string HTThanhToan { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> IDKhachHang { get; set; }
        public string Voucher { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual VOUCHER VOUCHER1 { get; set; }
    }
}
