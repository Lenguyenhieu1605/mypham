using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.Utilities.Exceptions
{
    public class WebMyPhamException : Exception
    {
        public WebMyPhamException()
        {

        }
        public WebMyPhamException(string message) : base(message)
        {

        }
        public WebMyPhamException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
