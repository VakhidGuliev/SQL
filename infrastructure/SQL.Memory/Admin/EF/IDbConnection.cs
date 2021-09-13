using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Memory.Admin.EF
{
  public  interface IDbConnection : IDisposable
    {
        /// <summary>Gets or sets the string used to open a database.</summary>
        /// <returns>A string containing connection settings.</returns>
        string ConnectionString { get; set; }
        /// <summary>Gets the name of the current database or the database to be used after a connection is opened.</summary>
        /// <returns>The name of the current database or the name of the database to be used once a connection is open. The default value is an empty string.</returns>
        string Database { get; }
        /// <summary>Closes the connection to the database.</summary>
        void Close();
        /// <summary>Changes the current database for an open <see langword="Connection" /> object.</summary>
        /// <param name="databaseName">The name of the database to use in place of the current database.</param>
        void ChangeDatabase(string databaseName);

        /// <summary>Creates and returns a Command object associated with the connection.</summary>
        /// <returns>A Command object associated with the connection.</returns>
        IDbCommand CreateCommand();

        /// <summary>Opens a database connection with the settings specified by the <see langword="ConnectionString" /> property of the provider-specific Connection object.</summary>
        void Open();
    }
}
