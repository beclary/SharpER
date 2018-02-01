// JobDB Data Access Layer (DAL) for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;

namespace SharpERDAL
{
    public static class JobDB
    {
        /// <summary>
        /// This will provide a listing of all Jobs that are available in the database
        /// </summary>
        public static List<Job> GetAllJobs()
        {
            List<Job> jobList = new List<Job>();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT * " +
                "FROM Job " +
                "ORDER BY JobID";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int jobJobIDOrd = readur.GetOrdinal("JobID");
                int jobJobPositionOrd = readur.GetOrdinal("JobPosition");
                int jobJobAppliedOrd = readur.GetOrdinal("JobApplied");
                int jobJobPayOrd = readur.GetOrdinal("JobPay");
                int jobJobContactIDOrd = readur.GetOrdinal("JobContactID");
                int jobJobCompanyIDOrd = readur.GetOrdinal("JobCompanyID");
                int jobJobNotesOrd = readur.GetOrdinal("JobNotes");

                while (readur.Read())
                {
                    Job jobRowInfo = new Job();
                    jobRowInfo.JobID = readur.GetInt32(jobJobIDOrd);
                    jobRowInfo.JobPosition = readur.GetString(jobJobPositionOrd);
                    jobRowInfo.JobApplied = readur.GetDateTime(jobJobAppliedOrd);
                    jobRowInfo.JobPay = readur.GetDecimal(jobJobPayOrd);
                    jobRowInfo.JobContactID = readur.GetInt32(jobJobContactIDOrd);
                    jobRowInfo.JobCompanyID = readur.GetInt32(jobJobCompanyIDOrd);
                    jobRowInfo.JobNotes = readur.GetString(jobJobNotesOrd);
                    jobList.Add(jobRowInfo);
                }
                readur.Close();
            }
            catch (SqlException xsept)
            {
                throw xsept;
            }
            catch (Exception xsept)
            {
                throw xsept;
            }
            finally
            {
                conn.Close();
            }
            return jobList;
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