using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.Data.Entities
{
    public class AppConfig : IdentityRole<Guid>
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
