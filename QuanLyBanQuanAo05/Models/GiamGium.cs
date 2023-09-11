﻿using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyBanQuanAo05.Models
{
    public partial class GiamGium
    {
        public GiamGium()
        {
            ChiTietDhs = new HashSet<ChiTietDh>();
        }

        public string MaGiamGia { get; set; }
        public string TenMaGiam { get; set; }

        public virtual ICollection<ChiTietDh> ChiTietDhs { get; set; }
    }
}
