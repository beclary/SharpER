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
            SqlDataReader readur = null;

            try
            {
                conn.Open();
                readur = selectCmd.ExecuteReader();
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
                    actRowInfo.ActivityID = readur.GetInt32(actActivityIDOrd);
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
                "SELECT act_id, act_date, act_description, act_travel, " +
                "act_job_id, act_contact_id, act_notes " +
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
        public static Activity GetSpecificActivityInfo(int activityID)
        {
            // TO DO : Not corrected for NULLS, be sure to fix these FIRST before using
            Activity specificActivity = new Activity();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT act_id, act_date, act_description, act_travel, " +
                "act_job_id, act_contact_id, act_notes " +
                "FROM Activity " +
                "WHERE act_id = @act_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            SqlDataReader readur = null;
            selectCmd.Parameters.AddWithValue("@act_id", activityID);

            try
            {
                conn.Open();
                readur = selectCmd.ExecuteReader();
                int actActivityIDOrd = readur.GetOrdinal("act_id");
                int actActivityDateOrd = readur.GetOrdinal("act_date");
                int actActivityDescriptionOrd = readur.GetOrdinal("act_desctiption");
                int actActivityTravelOrd = readur.GetOrdinal("act_travel");
                int actActivityJobIDOrd = readur.GetOrdinal("act_job_id");
                int actActivityContactIDOrd = readur.GetOrdinal("act_contact_id");
                int actActivityNotesOrd = readur.GetOrdinal("act_notes");

                readur.Read();
                if (readur[actActivityIDOrd] == DBNull.Value)
                    specificActivity = null;
                else
                    specificActivity.ActivityID = readur.GetInt32(actActivityIDOrd);

                // left out the dattime function ActivityDate

                if (readur[actActivityDescriptionOrd] == DBNull.Value)
                    specificActivity.ActivityDescription = null;
                else
                    specificActivity.ActivityDescription = readur.GetString(actActivityDescriptionOrd);

                if (readur[actActivityTravelOrd] == DBNull.Value)
                    specificActivity.ActivityTravel = null;
                else
                    specificActivity.ActivityTravel = readur.GetString(actActivityTravelOrd);

                if (readur[actActivityJobIDOrd] == DBNull.Value)
                    specificActivity.ActivityJobID = -1;
                else
                    specificActivity.ActivityJobID = readur.GetInt32(actActivityJobIDOrd);

                if (readur[actActivityContactIDOrd] == DBNull.Value)
                    specificActivity.ActivityContactID = -1;
                else
                    specificActivity.ActivityContactID = readur.GetInt32(actActivityContactIDOrd);

                if (readur[actActivityNotesOrd] == DBNull.Value)
                    specificActivity.ActivityNotes = "";
                else
                    specificActivity.ActivityNotes = readur.GetString(actActivityNotesOrd);
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
            return specificActivity;
        }

        // This is the method to update or modify (change) information on a form
        public static bool UpdateModifyActivity (Activity oldActivity, Activity newActivity)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string updateStmt =
                "UPDATE Activity SET " +
                "act_date = @NewActivityDate, " +
                "act_description = @NewActivityDescription, " +
                "act_travel = @NewActivityTravel, " +
                "act_job_id = @NewActivityJobID, " +
                "act_contact_id = @NewActivityContactID, " +
                "act_notes = @NewActivityNotes " +
                "WHERE act_id = @OldActivityID " +
                "AND (act_date = @OldActivityDate " +
                    "OR act_date IS NULL AND @OldActivityDate IS NULL) " +
                "AND (act_description = @OldActivityDescription " +
                    "OR act_description IS NULL AND @OldActivityDescription IS NULL) " +
                "AND (act_travel = @OldActivityTravel " +
                    "OR act_travel IS NULL AND @OldActivityTravel IS NULL) " +
                "AND (act_job_id = @OldActivityJobID " +
                    "OR act_job_id IS NULL AND @OldActivityJobID IS NULL) " +
                "AND (act_contact_id = @OldActivityContactID " +
                    "OR act_contact_id IS NULL AND @OldActivityContactID IS NULL) " +
                "AND (act_notes = @OldActivityNotes " +
                    "OR act_notes IS NULL AND @OldActivityNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);
            // Activity Date REQUIRED Field = so it will add whatever was accepted
                updateCmd.Parameters.AddWithValue("@NewActivityDate", newActivity.ActivityDate);

            // Activity Description
            if (newActivity.ActivityDescription == "")
            {
                updateCmd.Parameters.AddWithValue("@NewActivityDescription", DBNull.Value);
                updateCmd.Parameters["@NewActivityDescription"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewActivityDescription", newActivity.ActivityDescription);
            }

            // Activity Travel
            if (newActivity.ActivityTravel == "")
            {
                updateCmd.Parameters.AddWithValue("@NewActivityTravel", DBNull.Value);
                updateCmd.Parameters["@NewActivityTravel"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewActivityTravel", newActivity.ActivityTravel);
            }

            // Activity ContactID
            if (newActivity.ActivityContactID == -1)
            {
                updateCmd.Parameters.AddWithValue("@NewActivityContactID", DBNull.Value);
                updateCmd.Parameters["@NewActivityContactID"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewActivityContactID", newActivity.ActivityContactID);
            }

            // Activity JobID
            if (newActivity.ActivityJobID == -1) // This, until the Job form is done, is setting to a zero, when it should be a -1 (or treated as a null)
            {
                updateCmd.Parameters.AddWithValue("@NewActivityJobID", DBNull.Value);
                updateCmd.Parameters["@NewActivityJobID"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewActivityJobID", newActivity.ActivityJobID);
            }

            // Activity Notes
            if (newActivity.ActivityNotes == "")
            {
                updateCmd.Parameters.AddWithValue("@NewActivityNotes", DBNull.Value);
                updateCmd.Parameters["@NewActivityNotes"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewActivityNotes", newActivity.ActivityNotes);
            }




            // Old Activity changes
            // Activity Identification Number
            // Activity Date
            updateCmd.Parameters.AddWithValue("@OldActivityID", oldActivity.ActivityID);
            updateCmd.Parameters.AddWithValue("@OldActivityDate", oldActivity.ActivityDate);

            // Activity Description
            if (oldActivity.ActivityDescription == "")
            {
                updateCmd.Parameters.AddWithValue("@OldActivityDescription", DBNull.Value);
                updateCmd.Parameters["@OldActivityDescription"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldActivityDescription", oldActivity.ActivityDescription);
            }

            // Activity Travel
            if (oldActivity.ActivityTravel == "")
            {
                updateCmd.Parameters.AddWithValue("@OldActivityTravel", DBNull.Value);
                updateCmd.Parameters["@OldActivityTravel"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldActivityTravel", oldActivity.ActivityTravel);

            }

            // Activity ContactID
            if (oldActivity.ActivityContactID == -1)
            {
                updateCmd.Parameters.AddWithValue("@OldActivityContactID", DBNull.Value);
                updateCmd.Parameters["@OldActivityContactID"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldActivityContactID", oldActivity.ActivityContactID);
            }

            // Activity JobID
            if (oldActivity.ActivityJobID == -1) // See comment under the checking for new changes to 0
            {
                updateCmd.Parameters.AddWithValue("@OldActivityJobID", DBNull.Value);
                updateCmd.Parameters["@OldActivityJobID"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldActivityJobID", oldActivity.ActivityJobID);
            }

            // Activity Notes
            if (oldActivity.ActivityNotes == "")
            {
                updateCmd.Parameters.AddWithValue("@OldActivityNotes", DBNull.Value);
                updateCmd.Parameters["@OldActivityNotes"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldActivityNotes", oldActivity.ActivityNotes);
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
            catch (Exception xsept)
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
                "INSERT INTO Activity " +
                "(act_date, act_description, act_travel, act_contact_id, act_job_id, act_notes) " +
                "VALUES (@ActivityDate, @ActivityDescription, @ActivityTravel, @ActivityContactID, @ActivityJobID, @ActivityNotes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);

            // Activity Date
                insertCmd.Parameters.AddWithValue("@ActivityDate", newActivity.ActivityDate);

            // Activity Description
            if (newActivity.ActivityDescription == null)
            {
                insertCmd.Parameters.AddWithValue("@ActivityDescription", DBNull.Value);
                insertCmd.Parameters["@ActivityDescription"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@ActivityDescription", newActivity.ActivityDescription);
            }

            // Activity Travel
            if (newActivity.ActivityTravel == null)
            {
                insertCmd.Parameters.AddWithValue("@ActivityTravel", DBNull.Value);
                insertCmd.Parameters["@ActivityTravel"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@ActivityTravel", newActivity.ActivityTravel);
            }

            // Activity ContactID
            if (newActivity.ActivityContactID == 0)
            {
                insertCmd.Parameters.AddWithValue("@ActivityContactID", DBNull.Value);
                insertCmd.Parameters["@ActivityContactID"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@ActivityContactID", newActivity.ActivityContactID);
            }

            // Activity JobID
            if (newActivity.ActivityJobID == 0)
            {
                insertCmd.Parameters.AddWithValue("@ActivityJobID", DBNull.Value);
                insertCmd.Parameters["@ActivityJobID"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@ActivityJobID", newActivity.ActivityJobID);
            }

            // Activity Notes
            if (newActivity.ActivityNotes == null)
            {
                insertCmd.Parameters.AddWithValue("@ActivityNotes", DBNull.Value);
                insertCmd.Parameters["@ActivityNotes"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@ActivityNotes", newActivity.ActivityNotes);
            }

            try
            {
                conn.Open();
                insertCmd.ExecuteNonQuery();
                string selectStmt =
                    "SELECT IDENT_CURRENT ('Activity') FROM Activity";
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

        // This is the method to delete an activity
        public static int DeleteActivity (int activityID)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "DELETE FROM Activity " +
                "WHERE act_id = @ActivityID";
            SqlCommand deleteCmd = new SqlCommand(selectStmt, conn);
            deleteCmd.Parameters.AddWithValue("@ActivityID", activityID);

            try
            {
                conn.Open();
                int rowDel = Convert.ToInt32(deleteCmd.ExecuteNonQuery());
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