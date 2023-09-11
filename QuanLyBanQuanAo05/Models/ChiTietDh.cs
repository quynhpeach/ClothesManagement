using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyBanQuanAo05.Models
{
    public partial class ChiTietDh
    {
        public string MaSp { get; set; }
        public string MaGiamGia { get; set; }
        public int MaDh { get; set; }
        public double? DonGia { get; set; }
        public int? SoLuong { get; set; }

        public virtual DonHang MaDhNavigation { get; set; }
        public virtual GiamGium MaGiamGiaNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
