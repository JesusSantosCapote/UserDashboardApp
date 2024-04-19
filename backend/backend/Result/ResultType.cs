﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Result
{
    public enum ResultType
    {
        Ok,
        Invalid,
        Unauthorized,
        NotFound,
        Unexpected,
        NoContent,
        CreatedAt
    }
}
