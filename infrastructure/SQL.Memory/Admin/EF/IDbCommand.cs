using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQL.Memory.Admin.EF
{
    public interface IDbCommand : IDisposable
    {
        /// <summary>Gets or sets the <see cref="T:System.Data.IDbConnection" /> used by this instance of the <see cref="T:System.Data.IDbCommand" />.</summary>
        /// <returns>The connection to the data source.</returns>
        IDbConnection Connection { get; set; }

        

        /// <summary>Gets or sets the text command to run against the data source.</summary>
        /// <returns>The text command to execute. The default value is an empty string ("").</returns>
        string CommandText { get; set; }
        int CommandTimeout { get; set; }


        void Prepare();

        void Cancel();



        int ExecuteNonQuery();

        object ExecuteScalar();
    }
}
