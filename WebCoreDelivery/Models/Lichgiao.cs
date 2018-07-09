using System;
using System.Collections.Generic;

namespace WebCoreDelivery.Models
{
    public partial class Lichgiao
    {
        public int Lgid { get; set; }
        public int? SoHd { get; set; }
        public DateTime? Ngaygiao { get; set; }
        public decimal? Gia { get; set; }
        public bool? Show { get; set; }
    }
}
