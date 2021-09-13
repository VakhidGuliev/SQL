using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Memory.Admin.EF
{
    internal abstract class InternalContext : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public abstract DbConnection Connection { get; }
    }
}
