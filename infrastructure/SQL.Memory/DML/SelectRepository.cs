
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql;
using Sql.BL;
using Sql.BL.DML;
using SQL.Memory.Context;


namespace SQL.Memory.DML
{
  public  class SelectRepository : ISelect
  {
      private readonly Context.Context _context;
      public SelectRepository(Context.Context context)
      {
          _context = context;
      }
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
