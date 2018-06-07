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
                "ORDER BY job_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            SqlDataReader readur = null;

            try
            {
                conn.Open();
                readur = selectCmd.ExecuteReader();
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
                    // Both JobID and JobApplied are required fields, so they are listed as follows:
                    jobRowInfo.JobID = readur.GetInt32(jobJobIDOrd);
                    jobRowInfo.JobApplied = readur.GetDateTime(jobJobAppliedOrd);

                    // Te rest can all have been left blank:

                    // Job Position
                    if (readur[jobJobPositionOrd] == DBNull.Value)
                        jobRowInfo.JobPosition = "";
                    else
                        jobRowInfo.JobPosition = readur.GetString(jobJobPositionOrd);

                    // Job Pay
                    if (readur[jobJobPayOrd] == DBNull.Value)
                        jobRowInfo.JobPay = -1;
                    else
                        jobRowInfo.JobPay = readur.GetDecimal(jobJobPayOrd);

                    // Job Contact ID
                    if (readur[jobJobContactIDOrd] == DBNull.Value)
                        jobRowInfo.JobContactID = -1;
                    else
                        jobRowInfo.JobContactID = readur.GetInt32(jobJobContactIDOrd);

                    // Job Company ID
                    if (readur[jobJobCompanyIDOrd] == DBNull.Value)
                        jobRowInfo.JobCompanyID = -1;
                    else
                        jobRowInfo.JobCompanyID = readur.GetInt32(jobJobCompanyIDOrd);

                    // Job Notes
                    if (readur[jobJobNotesOrd] == DBNull.Value)
                        jobRowInfo.JobNotes = "";
                    else
                        jobRowInfo.JobNotes = readur.GetString(jobJobNotesOrd);

                    jobList.Add(jobRowInfo);
                }
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
                readur.Close();
                conn.Close();
            }
            return jobList;
        }

        // This will provide the job information given a specific job applied date
        public static Job GetSpecificJobInfo(DateTime jobID)
        {
            Job specificJob = new Job();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT job_id, job_position, job_applied, job_pay, " +
                "job_contact_id, job_company_id, job_notes " +
                "FROM Job " +
                "WHERE job_id = @job_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            SqlDataReader readur = null;
            selectCmd.Parameters.AddWithValue("@job_id", jobID);

            try
            {
                conn.Open();
                readur = selectCmd.ExecuteReader();
                int jobJobIDOrd = readur.GetOrdinal("job_id");
                int jobJobPositionOrd = readur.GetOrdinal("job_position");
                int jobJobAppliedOrd = readur.GetOrdinal("job_applied");
                int jobJobPayOrd = readur.GetOrdinal("job_pay");
                int jobJobContactIDOrd = readur.GetOrdinal("job_contact_id");
                int jobJobCompanyIDOrd = readur.GetOrdinal("job_company_id");
                int jobJobNotesOrd = readur.GetOrdinal("job_notes");

                readur.Read();
                // Job ID
                if (readur[jobJobIDOrd] == DBNull.Value)
                    specificJob = null;
                else
                    specificJob.JobID = readur.GetInt32(jobJobIDOrd);

                // Job Position
                if (readur[jobJobPositionOrd] == DBNull.Value)
                    specificJob.JobPosition = null;
                else
                    specificJob.JobPosition = readur.GetString(jobJobPositionOrd);

                // Job Applied
                if (readur[jobJobAppliedOrd] == DBNull.Value)
                    specificJob.JobApplied = DateTime.Now;
                else
                    specificJob.JobApplied = readur.GetDateTime(jobJobAppliedOrd);

                // Job Pay
                if (readur[jobJobPayOrd] == DBNull.Value)
                    specificJob.JobPay = -1;
                else
                    specificJob.JobPay = readur.GetDecimal(jobJobPayOrd);

                // Job Contact ID
                if (readur[jobJobContactIDOrd] == DBNull.Value)
                    specificJob.JobContactID = -1;
                else
                    specificJob.JobContactID = readur.GetInt32(jobJobContactIDOrd);

                // Job Company ID
                if (readur[jobJobCompanyIDOrd] == DBNull.Value)
                    specificJob.JobCompanyID = -1;
                else
                    specificJob.JobCompanyID = readur.GetInt32(jobJobCompanyIDOrd);

                // Job Notes
                if (readur[jobJobNotesOrd] == DBNull.Value)
                    specificJob.JobNotes = null;
                else
                    specificJob.JobNotes = readur.GetString(jobJobNotesOrd);
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
                readur.Close();
                conn.Close();
            }
            return specificJob;
        }

        // This is the method to view or modify (change) information on a form
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
                "AND (job_position = @OldJobPosition " +
                    "OR job_position IS NULL AND @OldJobPosition IS NULL) " +
                "AND (job_applied = @OldJobApplied " +
                    "OR job_applied IS NULL AND @OldJobApplied IS NULL) " +
                "AND (job_pay = @OldJobPay " +
                    "OR job_pay IS NULL AND @OldJobPay IS NULL) " +
                "AND (job_contact_id = @OldJobContactID " +
                    "OR job_contact_id IS NULL AND @OldJobContactID IS NULL) " +
                "AND (job_company_id = @OldJobCompanyID " +
                    "OR job_company_id IS NULL AND @OldJobCompanyID IS NULL) " +
                "AND (job_notes = @OldJobNotes " +
                    "OR job_notes IS NULL AND @OldJobNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);

            // New Job changes (must have position and date)
            // Job Position
            if (newJob.JobPosition == "")
            {
                updateCmd.Parameters.AddWithValue("@NewJobPosition", DBNull.Value);
                updateCmd.Parameters["@NewJobPosition"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewJobPosition", newJob.JobPosition);
            }

            // Job Applied - Mandatory DateTime field
            //if (newJob.JobApplied == null)
            //{
            //    updateCmd.Parameters.AddWithValue("@NewJobApplied", DBNull.Value);
            //    updateCmd.Parameters["@NewJobApplied"].IsNullable = true;
            //}
            //else
            //{
                updateCmd.Parameters.AddWithValue("@NewJobApplied", newJob.JobApplied);
            //}

            // Job Pay
            if (newJob.JobPay == -1)
            {
                updateCmd.Parameters.AddWithValue("@NewJobPay", DBNull.Value);
                updateCmd.Parameters["@NewJobPay"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewJobPay", newJob.JobPay);
            }

            // Job Contact's ID number
            if (newJob.JobContactID == -1)
            {
                updateCmd.Parameters.AddWithValue("@NewJobContactID", DBNull.Value);
                updateCmd.Parameters["@NewJobContactID"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewJobContactID", newJob.JobContactID);
            }

            // Job Company's ID number
            if (newJob.JobCompanyID == -1)
            {
                updateCmd.Parameters.AddWithValue("@NewJobCompanyID", DBNull.Value);
                updateCmd.Parameters["@NewJobCompanyID"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewJobCompanyID", newJob.JobCompanyID);
            }

            // Job Notes
            if (newJob.JobNotes == "")
            {
                updateCmd.Parameters.AddWithValue("@NewJobNotes", DBNull.Value);
                updateCmd.Parameters["@NewJobNotes"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewJobNotes", newJob.JobNotes);
            }

            // Old Job changes
            // Job Position
            updateCmd.Parameters.AddWithValue("@OldJobID", oldJob.JobID);

            if (oldJob.JobPosition == "")
            {
                updateCmd.Parameters.AddWithValue("@OldJobPosition", DBNull.Value);
                updateCmd.Parameters["@OldJobPosition"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldJobPosition", oldJob.JobPosition);
            }

            // Job Applied
            //if (oldJob.JobApplied == null)
            //{
            //    updateCmd.Parameters.AddWithValue("@OldJobApplied", DBNull.Value);
            //    updateCmd.Parameters["@OldJobApplied"].IsNullable = true;
            //}
            //else
            //{
                updateCmd.Parameters.AddWithValue("@OldJobApplied", oldJob.JobApplied);
            //}

            // Job Pay
            if (oldJob.JobPay == -1)
            {
                updateCmd.Parameters.AddWithValue("@OldJobPay", DBNull.Value);
                updateCmd.Parameters["@OldJobPay"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldJobPay", oldJob.JobPay);
            }

            // Job Contact's ID number
            if (oldJob.JobContactID == -1)
            {
                updateCmd.Parameters.AddWithValue("@OldJobContactID", DBNull.Value);
                updateCmd.Parameters["@OldJobContactID"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldJobContactID", oldJob.JobContactID);
            }

            // Job Company's ID number
            if (oldJob.JobCompanyID == -1)
            {
                updateCmd.Parameters.AddWithValue("@OldJobCompanyID", DBNull.Value);
                updateCmd.Parameters["@OldJobCompanyID"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldJobCompanyID", oldJob.JobCompanyID);
            }

            // Job Notes
            if (oldJob.JobNotes == "")
            {
                updateCmd.Parameters.AddWithValue("@OldJobNotes", DBNull.Value);
                updateCmd.Parameters["@OldJobNotes"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldJobNotes", oldJob.JobNotes);
            }

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
            catch(Exception xsept)
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
                "INSERT INTO Job " +
                "(job_position, job_applied, job_pay, job_contact_id, job_company_id, job_notes) " +
                "VALUES (@JobPosition, @JobApplied, @JobPay, @JobContactID, @JobCompanyID, @JobNotes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);

            // Job Position
            if (newJob.JobPosition == null)
            {
                insertCmd.Parameters.AddWithValue("@JobPosition", DBNull.Value);
                insertCmd.Parameters["@JobApplied"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@JobPosition", newJob.JobPosition);
            }

            // Job Applied
            if (newJob.JobApplied == null)
            {
                insertCmd.Parameters.AddWithValue("@JobApplied", DBNull.Value);
                insertCmd.Parameters["@JobApplied"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@JobApplied", newJob.JobApplied);
            }

            // Job Pay
            if (newJob.JobPay == -1)
            {
                insertCmd.Parameters.AddWithValue("@JobPay", DBNull.Value);
                insertCmd.Parameters["@JobPay"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@JobPay", newJob.JobPay);
            }

            // Job Contact's ID number
            if (newJob.JobContactID == -1)
            {
                insertCmd.Parameters.AddWithValue("@JobContactID", DBNull.Value);
                insertCmd.Parameters["@JobContactID"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@JobContactID", newJob.JobContactID);
            }

            // Job Company's ID number
            if (newJob.JobCompanyID == -1)
            {
                insertCmd.Parameters.AddWithValue("@JobCompanyID", DBNull.Value);
                insertCmd.Parameters["@JobCompanyID"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@JobCompanyID", newJob.JobCompanyID);
            }

            // Job Notes
            if (newJob.JobNotes == null)
            {
                insertCmd.Parameters.AddWithValue("@JobNotes", DBNull.Value);
                insertCmd.Parameters["@JobNotes"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@JobNotes", newJob.JobNotes);
            }

            try
            {
                conn.Open();
                insertCmd.ExecuteNonQuery();
                string selectStmt =
                    "SELECT IDENT_CURRENT ('Job') FROM Job";
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

        public static int DeleteJob (int jobID)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "DELETE FROM Job " +
                "WHERE job_id = @Job_ID";
            SqlCommand deleteCmd = new SqlCommand(selectStmt, conn);
            deleteCmd.Parameters.AddWithValue("@Job_ID", jobID);

            try
            {
                conn.Open();
                int rowDel = Convert.ToInt32(deleteCmd.ExecuteScalar());
                return rowDel;
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