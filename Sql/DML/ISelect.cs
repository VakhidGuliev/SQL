﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.DML
{
   public interface ISelect
    {
        List<Object> SELECT();
        Object SELECT(Column column);
    }
}
