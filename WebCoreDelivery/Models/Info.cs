using System;
using System.Collections.Generic;

namespace WebCoreDelivery.Models
{
    public partial class Info
    {
        public int InfoId { get; set; }
        public string Stt { get; set; }
        public string Hoten { get; set; }
        public int? Sdt { get; set; }
        public int? Sdtkhac { get; set; }
        public string Diachi { get; set; }
        public int? SoHd { get; set; }
        public DateTime? NgaykyHd { get; set; }
        public string Duan { get; set; }
        public string Solo { get; set; }
        public int? Dotdadong { get; set; }
        public decimal? Tiendadong { get; set; }
        public DateTime? Denngay { get; set; }
        public decimal? GiatriHd { get; set; }
        public DateTime? Thoigiangiao { get; set; }
        public string Phantramdadong { get; set; }
    }
}
