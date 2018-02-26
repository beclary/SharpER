// ActivityDB Data Access Layer (DAL) for SharpER
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
    public static class ActivityDB
    {
        // This will provide a listing of all the activities in the database
        public static List<Activity> GetAllActivities()
        {
            List<Activity> activityList = new List<Activity>();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT * " +
                "FROM Activity " +
                "ORDER BY act_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int actActivityIDOrd = readur.GetOrdinal("act_id");
                int actActivityDateOrd = readur.GetOrdinal("act_date");
                int actActivityDescriptionOrd = readur.GetOrdinal("act_description");
                int actActivityTravelOrd = readur.GetOrdinal("act_travel");
                int actActivityJobIDOrd = readur.GetOrdinal("act_job_id");
                int actActivityContactIDOrd = readur.GetOrdinal("act_Contact_id");
                int actActivityNotesOrd = readur.GetOrdinal("act_notes");

                while (readur.Read())
                {
                    Activity actRowInfo = new Activity();
                    if (readur[actActivityIDOrd] == DBNull.Value)
                        actRowInfo.ActivityID = -1;
                    else
                        actRowInfo.ActivityID = readur.GetInt32(actActivityIDOrd);

                    // Requires them to enter a date before entering any activity done
                    actRowInfo.ActivityDate = readur.GetDateTime(actActivityDateOrd);

                    if (readur[actActivityDescriptionOrd] == DBNull.Value)
                        actRowInfo.ActivityDescription = "";
                    else
                        actRowInfo.ActivityDescription = readur.GetString(actActivityDescriptionOrd);
                    if (readur[actActivityTravelOrd] == DBNull.Value)
                        actRowInfo.ActivityTravel = "";
                    else
                        actRowInfo.ActivityTravel = readur.GetString(actActivityTravelOrd);
                    if (readur[actActivityJobIDOrd] == DBNull.Value)
                        actRowInfo.ActivityJobID = -1;
                    else
                        actRowInfo.ActivityJobID = readur.GetInt32(actActivityJobIDOrd);
                    if (readur[actActivityContactIDOrd] == DBNull.Value)
                        actRowInfo.ActivityContactID = -1;
                    else
                        actRowInfo.ActivityContactID = readur.GetInt32(actActivityContactIDOrd);
                    if (readur[actActivityNotesOrd] == DBNull.Value)
                        actRowInfo.ActivityNotes = "";
                    else
                        actRowInfo.ActivityNotes = readur.GetString(actActivityNotesOrd);
                    activityList.Add(actRowInfo);
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
            return activityList;
        }

        // This will provide a list of the activity that was done given a specific date.
        // This will probably be the most used search for this table

        
        public static Activity GetActivityByDate(DateTime activityDate)
        {
            // TO DO : Not corrected for NULLS, be sure to fix these FIRST before using
            Activity specificActivityByDate = new Activity();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT act_id, act_date, act_description, , act_travel, " +
                "act_contact_id, act_job_id, act_notes " +
                "FROM Activity " +
                "WHERE act_date = @act_date";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            selectCmd.Parameters.AddWithValue("@act_date", activityDate);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int actActivityIDOrd = readur.GetOrdinal("act_id");
                int actActivityDateOrd = readur.GetOrdinal("act_date");
                int actActivityDescriptionOrd = readur.GetOrdinal("act_description");
                int actActivityTravelOrd = readur.GetOrdinal("act_travel");
                int actActivityJobIDOrd = readur.GetOrdinal("act_job_id");
                int actActivityContactIDOrd = readur.GetOrdinal("act_contact_id");
                int actActivityNotesOrd = readur.GetOrdinal("act_notes");

                while (readur.Read())
                {
                    Activity actRowInfo = new Activity();
                    if (readur[actActivityIDOrd] == DBNull.Value)
                        actRowInfo.ActivityID = -1;
                    else
                        actRowInfo.ActivityID = readur.GetInt32(actActivityIDOrd);

                    // Requires them to enter a date for when an activity was done
                    actRowInfo.ActivityDate = readur.GetDateTime(actActivityDateOrd);

                    if (readur[actActivityDescriptionOrd] == DBNull.Value)
                        actRowInfo.ActivityDescription = "";
                    else
                        actRowInfo.ActivityDescription = readur.GetString(actActivityDescriptionOrd);
                    if (readur[actActivityTravelOrd] == DBNull.Value)
                        actRowInfo.ActivityTravel = "";
                    else
                        actRowInfo.ActivityTravel = readur.GetString(actActivityTravelOrd);
                    if (readur[actActivityJobIDOrd] == DBNull.Value)
                        actRowInfo.ActivityJobID = -1;
                    else
                        actRowInfo.ActivityJobID = readur.GetInt32(actActivityJobIDOrd);
                    if (readur[actActivityContactIDOrd] == DBNull.Value)
                        actRowInfo.ActivityContactID = -1;
                    else
                        actRowInfo.ActivityContactID = readur.GetInt32(actActivityContactIDOrd);
                    if (readur[actActivityNotesOrd] == DBNull.Value)
                        actRowInfo.ActivityNotes = "";
                    else
                        actRowInfo.ActivityNotes = readur.GetString(actActivityNotesOrd);
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
            return specificActivityByDate;
        }

        // This will provide the activity that was done given a specific activityID
        public static Activity GetSpecificActivityInfo(string activityID)
        {
            // TO DO : Not corrected for NULLS, be sure to fix these FIRST before using
            Activity specificActivity = new Activity();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT act_id, act_date, act_description, act_travel, " +
                "act_contact_id, act_Job_id, act_contact_id, act_notes " +
                "FROM Activity " +
                "WHERE act_id = @act_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            selectCmd.Parameters.AddWithValue("@act_id", activityID);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int actActivityIDOrd = readur.GetOrdinal("act_id");
                int actActivityDateOrd = readur.GetOrdinal("act_date");
                int actActivityDescriptionOrd = readur.GetOrdinal("act_desctiption");
                int actActivityTravelOrd = readur.GetOrdinal("act_travel");
                int actActivityContactIDOrd = readur.GetOrdinal("act_contact_id");
                int actActivityJobIDOrd = readur.GetOrdinal("act_job_id");
                int actActivityNotesOrd = readur.GetOrdinal("act_notes");

                while (readur.Read())
                {
                    Activity actRowInfo = new Activity();
                    actRowInfo.ActivityID = readur.GetInt32(actActivityIDOrd);
                    actRowInfo.ActivityDate = readur.GetDateTime(actActivityDateOrd);
                    actRowInfo.ActivityDescription = readur.GetString(actActivityDescriptionOrd);
                    actRowInfo.ActivityTravel = readur.GetString(actActivityTravelOrd);
                    actRowInfo.ActivityContactID = readur.GetInt32(actActivityContactIDOrd);
                    actRowInfo.ActivityJobID = readur.GetInt32(actActivityJobIDOrd);
                    actRowInfo.ActivityNotes = readur.GetString(actActivityNotesOrd);
                }
                readur.Close();
            }
            catch (Exception xsept)
            {
                throw xsept;
            }
            finally
            {
                conn.Close();
            }
            return specificActivity;

        }

        // This is the methof to update or modify (change) information on a form
        public static bool UpdateModifyActivity (Activity oldActivity, Activity newActivity)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string updateStmt =
                "UPDATE Activity SET " +
                "act_date = @NewActivityDate, " +
                "act_description = @NewActivityDescription, " +
                "act_travel = @NewActivityTravel, " +
                "act_contact_id = @NewActivityContactID, " +
                "act-job_id = @NewActivityJobID, " +
                "act_notes = @NewActivityNotes " +
                "WHERE act_id = @OldActivityID " +
                "AND act_date = @OldActivityDate " +
                "AND act_description = @OldActivityDescription " +
                "AND act_travel = @OldActivityTravel " +
                "AND (act_contact_id = @OldActivityContactID " +
                    "OR act_contact_id IS NULL AND @OldActivityContactID IS NULL) " +
                "AND (act_job_id = @OldActivityJobID " +
                    "OR act_job_id IS NULL AND @OldActivityJobID IS NULL) " +
                "AND (act_notes = @OldActivityNotes " +
                    "OR act_notes IS NULL AND @OldActivityNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);

            // New Activity changes
            updateCmd.Parameters.AddWithValue("@NewActivityDate", newActivity.ActivityDate);
            updateCmd.Parameters.AddWithValue("@NewActivityDescription", newActivity.ActivityDescription);
            updateCmd.Parameters.AddWithValue("@NewActivityTravel", newActivity.ActivityTravel);
            if (newActivity.ActivityContactID == -1)
                updateCmd.Parameters.AddWithValue("@NewActivityContactID", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewActivityContactID", newActivity.ActivityContactID);
            if (newActivity.ActivityJobID == -1)
                updateCmd.Parameters.AddWithValue("@NewActivityJobID", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewActivityJobID", newActivity.ActivityJobID);
            if (newActivity.ActivityNotes == "")
                updateCmd.Parameters.AddWithValue("@NewActivityNotes", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewActivityNotes", newActivity.ActivityNotes);

            // Old Activity changes
            updateCmd.Parameters.AddWithValue("@OldActivityDate", oldActivity.ActivityDate);
            updateCmd.Parameters.AddWithValue("@OldActivityDescription", oldActivity.ActivityDescription);
            updateCmd.Parameters.AddWithValue("@OldActivityTravel", oldActivity.ActivityTravel);
            if (oldActivity.ActivityContactID == -1)
                updateCmd.Parameters.AddWithValue("@OldActivityContactID", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldActivityContactID", oldActivity.ActivityContactID);
            if (newActivity.ActivityJobID == -1)
                updateCmd.Parameters.AddWithValue("@OldActivityJobID", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldActivityJobID", newActivity.ActivityJobID);
            if (oldActivity.ActivityNotes == "")
                updateCmd.Parameters.AddWithValue("@OldActivityNotes", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldActivityNotes", oldActivity.ActivityNotes);

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

        // This is the method to add an activity
        public static int AddActivity (Activity newActivity)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string insertStmt =
                "(act_date, act_description, act_travel, act_job_id, " +
                "act_contact_id, act_notes) " +
                "VALUES (@ActivityDate, @ActivityDescription, @ActivityTravel, " +
                "@ActivityContactID, @ActivityJobID, @ActivityNotes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);
            insertCmd.Parameters.AddWithValue("@ActivityDate", newActivity.ActivityDate);
            insertCmd.Parameters.AddWithValue("@ActivityDescription", newActivity.ActivityDescription);
            insertCmd.Parameters.AddWithValue("@ActivityTravel", newActivity.ActivityTravel);
            if (newActivity.ActivityContactID == -1)
                insertCmd.Parameters.AddWithValue("@ActivityContactID", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ActivityContactID", newActivity.ActivityContactID);
            if (newActivity.ActivityJobID == -1)
                insertCmd.Parameters.AddWithValue("@ActivityJobID", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ActivityJobID", newActivity.ActivityJobID);
            if (newActivity.ActivityNotes == "")
                insertCmd.Parameters.AddWithValue("@ActivityNotes", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ActivityNotes", newActivity.ActivityNotes);

            try
            {
                conn.Open();
                insertCmd.ExecuteNonQuery();
                string selectStmt =
                    "SELECT SCOPE_IDENTITY ('Activity') FROM Activity";
                SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
                int activityID = Convert.ToInt32(selectCmd.ExecuteScalar());
                return activityID;
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