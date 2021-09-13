using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql.BL
{
   public class Column
    {
        public int Id { get; }
        public int RowId { get; }
        public object DataType { get; }
        public bool AllowNull { get; }
    }
}
