using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql
{
    public abstract class SqlItem
    {
        public string Query { get; }
        public string ConnectionStrings { get; }
        public Object SqlResult { get; }
        

    }
}
