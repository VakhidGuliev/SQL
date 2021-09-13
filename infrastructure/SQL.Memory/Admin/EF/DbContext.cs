using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Memory.Admin.EF
{
 public  class DbContext :IDisposable
    {
        private InternalContext _internalContext;
        private Database _database;

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize((object)this);
        }
        protected virtual void Dispose(bool disposing) => this._internalContext.Dispose();
        public Database Database
        {
            get
            {
                if (this._database == null)
                    this._database = new Database(this.InternalContext);
                return this._database;
            }
        }
        internal virtual InternalContext InternalContext => this._internalContext;

    }
}
