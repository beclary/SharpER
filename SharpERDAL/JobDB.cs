using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;

namespace SharpERDAL
{
    public class JobDB
    {
        /// <summary>
        /// This will provide a listing of all Jobs that are available in the database
        /// </summary>
        public static List<Job> GetAllJobs()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This will provide the job information given a specific jobID
        /// </summary>
        public static Job GetSpecificJobInfo(int jobID)
        {
            throw new System.NotImplementedException();
        }
    }
}