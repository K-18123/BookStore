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
    
    public partial class CHITIETDONHANG
    {
        public int IDDonHang { get; set; }
        public int IDSach { get; set; }
        public Nullable<int> SL { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    
        public virtual DONHANG DONHANG { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
