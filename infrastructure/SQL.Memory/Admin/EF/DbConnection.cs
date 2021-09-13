using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Memory.Admin.EF
{
    public abstract class DbConnection : IDisposable
    {
        [RecommendedAsConfigurable(true)]
        [SettingsBindable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public abstract string ConnectionString { get; set; }
        public abstract string Database { get; }

        public virtual int ConnectionTimeout => 15;
        public abstract string DataSource { get; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public abstract void Open();
        public abstract void Close();
    }
}
