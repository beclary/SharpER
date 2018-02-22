﻿// JobDB Data Access Layer (DAL) for SharpER
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
                "ORDER BY job_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int jobJobIDOrd = readur.GetOrdinal("job_id");
                int jobJobPositionOrd = readur.GetOrdinal("job_position");
                int jobJobAppliedOrd = readur.GetOrdinal("job_applied");
                int jobJobPayOrd = readur.GetOrdinal("job_pay");
                int jobJobContactIDOrd = readur.GetOrdinal("job_contact_id");
                int jobJobCompanyIDOrd = readur.GetOrdinal("job_company_id");
                int jobJobNotesOrd = readur.GetOrdinal("job_notes");

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
                "job_position = @NewJobPosition, " +
                "job_applied = @NewJobApplied, " +
                "job_pay = @NewJobPay, " +
                "job_contact_id = @NewJobContactID, " +
                "job_company_id = @NewJobCompanyID, " +
                "job_notes = @NewJobNotes " +
                "WHERE job_id = @OldJobID " +
                "AND job_position = @OldJobPosition " +
                "AND job_applied = @OldJobApplied " +
                "AND (job_pay = @OldJobPay " +
                    "OR job_pay IS NULL AND @OldJobPay IS NULL) " +
                "AND (job_contact_id = @OldJobContactID " +
                    "OR job_contact_id IS NULL AND @OldJobContactID IS NULL) " +
                "AND (job_notes = @OldJobNotes " +
                    "OR job_notes IS NULL AND @OldJobNotes IS NULL)";
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

        // This is the method to add a job
        public static int AddJob (Job newJob)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string insertStmt =
                "INSERT Job " +
                "(job_position, job_applied, job_pay, job_contact_id, job_company_id, job_notes) " +
                "VALUES (@JobPosition, @JobApplied, @JobPay, @JobContactID, @JobCompanyID, @JobNotes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);
            insertCmd.Parameters.AddWithValue("@JobPosition", newJob.JobPosition);
            insertCmd.Parameters.AddWithValue("@JobApplied", newJob.JobApplied);
            if (newJob.JobPay == -1)
                insertCmd.Parameters.AddWithValue("@JobPay", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@JobPay", newJob.JobPay);
            if (newJob.JobContactID == -1)
                insertCmd.Parameters.AddWithValue("@JobContactID", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@JobContactID", newJob.JobContactID);
            if (newJob.JobCompanyID == -1)
                insertCmd.Parameters.AddWithValue("@JobCompanyID", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@JobCompanyID", newJob.JobCompanyID);
            if (newJob.JobNotes == "")
                insertCmd.Parameters.AddWithValue("@JobNotes", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@JobNotes", newJob.JobNotes);

            try
            {
                conn.Open();
                insertCmd.ExecuteNonQuery();
                string selectStmt =
                    "SELECT SCOPE_IDENTITY ('Job') FROM Job";
                SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
                int jobID = Convert.ToInt32(selectCmd.ExecuteScalar());
                return jobID;
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
        }
    }
}