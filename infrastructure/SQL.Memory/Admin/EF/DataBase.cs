using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sql.BL;

namespace SQL.Memory.Admin.EF
{
    public class Database
    {
      
        private readonly InternalContext _internalContext;


        internal Database(InternalContext internalContext) => this._internalContext = internalContext;

        public DbConnection Connection => this._internalContext.Connection;

    }
}
