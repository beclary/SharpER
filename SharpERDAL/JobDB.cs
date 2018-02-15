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
        // This will provide a listing of all Jobs that are available in the database
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

        // This will provide the job information given a specific jobID
        public static Job GetSpecificJobInfo(int jobID)
        {
            throw new System.NotImplementedException();
        }

        // This is the method to update or modify (change) information on a form
        public static bool UpdateModifyJob (Job oldJob, Job newJob)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string updateStmt =
                "UPDATE Job SET " +
                "JobPosition = @NewJobPosition, " +
                "JobApplied = @NewJobApplied, " +
                "JobPay = @NewJobPay, " +
                "JobContactID = @NewJobContactID, " +
                "JobCompanyID = @NewJobCompanyID, " +
                "JobNotes = @NewJobNotes " +
                "WHERE JobID = @OldJobID " +
                "AND JobPosition = @OldJobPosition " +
                "AND JobApplied = @OldJobApplied " +
                "AND (JobPay = @OldJobPay " +
                    "OR JobPay IS NULL AND @OldJobPay IS NULL) " +
                "AND (JobContactID = @OldJobContactID " +
                    "OR JobContactID IS NULL AND @OldJobContactID IS NULL) " +
                "AND (JobNotes = @OldJobNotes " +
                    "OR JobNotes IS NULL AND @OldJobNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);

            // New Job changes
            updateCmd.Parameters.AddWithValue("@NewJobPosition", newJob.JobPosition);
            updateCmd.Parameters.AddWithValue("@NewJobApplied", newJob.JobApplied);
            if (newJob.JobPay == -1)
                updateCmd.Parameters.AddWithValue("@NewJobPay", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewJobPay", newJob.JobPay);
            if (newJob.JobContactID == -1)
                updateCmd.Parameters.AddWithValue("@NewJobContactID", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewJobContactID", newJob.JobContactID);
            if (newJob.JobNotes == "")
                updateCmd.Parameters.AddWithValue("@NewJobNotes", newJob.JobNotes);

            // Old Job changes
            updateCmd.Parameters.AddWithValue("@OldJobPosition", oldJob.JobPosition);
            updateCmd.Parameters.AddWithValue("@OldJobApplied", oldJob.JobApplied);
            if (oldJob.JobPay == -1)
                updateCmd.Parameters.AddWithValue("@OldJobPay", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldJobPay", oldJob.JobPay);
            if (oldJob.JobCompanyID == -1)
                updateCmd.Parameters.AddWithValue("@OldJobContactID", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldJobContactID", oldJob.JobContactID);
            if (oldJob.JobNotes == "")
                updateCmd.Parameters.AddWithValue("@OldJobNotes", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldJobNotes", oldJob.JobNotes);

            try
            {
                conn.Open();
                int count = updateCmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException xsept)
            {
                throw xsept;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}