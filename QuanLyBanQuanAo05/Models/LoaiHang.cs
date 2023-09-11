using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyBanQuanAo05.Models
{
    public partial class LoaiHang
    {
        public LoaiHang()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaLh { get; set; }
        public string TenLh { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
