using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql;
using Sql.DML;

namespace SQL.Memory.DML
{
    class SelectRepository : ISelect
    {
        public List<object> SELECT()
        {
            throw new NotImplementedException();
        }
        //TODO:Implement with predicate
        public object SELECT(Column column)
        {
            throw new NotImplementedException();
        }

    }
}
