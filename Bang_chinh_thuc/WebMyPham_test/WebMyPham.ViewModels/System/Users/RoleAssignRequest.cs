using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>(); //list item
    }
}
