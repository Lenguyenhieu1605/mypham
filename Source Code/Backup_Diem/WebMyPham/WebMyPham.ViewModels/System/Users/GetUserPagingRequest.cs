using System;
using System.Collections.Generic;
using System.Text;
using WebMyPham.ViewModels.Common;

namespace WebMyPham.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }


    }
}
