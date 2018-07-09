using System;
using System.Collections.Generic;

namespace WebCoreDelivery.Models
{
    public partial class Email
    {
        public int EmailId { get; set; }
        public string Hoten { get; set; }
        public string Chucvu { get; set; }
        public string Email1 { get; set; }
        public int? Sdt { get; set; }
    }
}
