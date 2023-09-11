using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyBanQuanAo05.Models
{
    public partial class Size
    {
        public Size()
        {
            SanPhamSizes = new HashSet<SanPhamSize>();
        }

        public string Size1 { get; set; }

        public virtual ICollection<SanPhamSize> SanPhamSizes { get; set; }
    }
}
