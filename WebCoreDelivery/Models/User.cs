using System;
using System.Collections.Generic;

namespace WebCoreDelivery.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public int? Sdt { get; set; }
    }
}
