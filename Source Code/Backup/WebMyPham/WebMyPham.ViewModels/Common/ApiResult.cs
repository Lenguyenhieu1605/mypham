﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebMyPham.ViewModels.Common
{
    public class ApiResult<T>
    {

        public bool IsSuccessed { get; set; }

        public string Message { get; set; }

        public T ResultObj { get; set; }
    }
}
