using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpERBLL;
using System.Data.SqlClient;

namespace SharpERDAL
{
    public class SharpERDB
    {
        /// <summary>
        /// This is the method that opens the connection
        /// </summary>
        /// <remarks>
        /// This is a static method.
        /// It will create a connection string builder object from the SqlConnectionStringBuilder type. This will be used to assign the:
        /// 1) DataSource
        /// 2) InitialCatalog and 
        /// 3) IntegratedSecurity
        /// Then it will create a connection object that can be used to open, close, or dispose of the connection
        /// </remarks>
        /// <returns>A SqlConnection object</returns>
        public static SqlConnection GetConnection()
        {
            throw new System.NotImplementedException();
        }
    }
}