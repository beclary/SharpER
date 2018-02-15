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
                "ORDER BY ActivityID";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int actActivityIDOrd = readur.GetOrdinal("ActivityID");
                int actActivityDateOrd = readur.GetOrdinal("ActivityDate");
                int actActivityDescriptionOrd = readur.GetOrdinal("ActivityDescription");
                int actActivityTravelOrd = readur.GetOrdinal("ActivityTravel");
                int actActivityJobIDOrd = readur.GetOrdinal("ActivityJobID");
                int actActivityContactIDOrd = readur.GetOrdinal("ActivityContactID");
                int actActivityNotesOrd = readur.GetOrdinal("ActivityNotes");

                while (readur.Read())
                {
                    Activity actRowInfo = new Activity();
                    actRowInfo.ActivityID = readur.GetInt32(actActivityIDOrd);
                    actRowInfo.ActivityDate = readur.GetDateTime(actActivityDateOrd);
                    actRowInfo.ActivityDescription = readur.GetString(actActivityDescriptionOrd);
                    actRowInfo.ActivityTravel = readur.GetString(actActivityTravelOrd);
                    actRowInfo.ActivityJobID = readur.GetInt32(actActivityJobIDOrd);
                    actRowInfo.ActivityContactID = readur.GetInt32(actActivityContactIDOrd);
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

        // This will provide a list of the activity that was done given a specific date
        public static Activity GetActivityByDate(DateTime activityDate)
        {
            throw new System.NotImplementedException();
        }

        // This will provide the activity that was done given a specific activityID
        public static Activity GetSpecificActivityInfo(string activityID)
        {
            Activity specificActivity = new Activity();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT ActivityID, ActivityDate, ActivityDescription, ActivityTravel, " +
                "ActivityContactID, ActivityJobID, ActivityNotes " +
                "FROM Activity " +
                "WHERE ActivityID = @ActivityID";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            selectCmd.Parameters.AddWithValue("@ActivityID", activityID);

            try
            {
                conn.Open();
                return specificActivity;
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

        // This is the methof to update or modify (change) information on a form
        public static bool UpdateModifyActivity (Activity oldActivity, Activity newActivity)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string updateStmt =
                "UPDATE Activity SET " +
                "ActivityDate = @NewActivityDate, " +
                "ActivityDescription = @NewActivityDescription, " +
                "ActivityTravel = @NewActivityTravel, " +
                "ActivityContactID = @NewActivityContactID, " +
                "ActivityNotes = @NewActivityNotes " +
                "WHERE ActivityID = @OldActivityID " +
                "AND ActivityDate = @OldActivityDate " +
                "AND ActivityDescription = @OldActivityDescription " +
                "AND ActivityTravel = @OldActivityTravel " +
                "AND (ActivityContactID = @OldActivityContactID " +
                    "OR ActivityContactID IS NULL AND @OldActivityContactID IS NULL) " +
                "AND (ActivityNotes = @OldActivityNotes " +
                    "OR ActivityNotes IS NULL AND @OldActivityNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);

            // New Activity changes
            updateCmd.Parameters.AddWithValue("@NewActivityDate", newActivity.ActivityDate);
            updateCmd.Parameters.AddWithValue("@NewActivityDescription", newActivity.ActivityDescription);
            updateCmd.Parameters.AddWithValue("@NewActivityTravel", newActivity.ActivityTravel);
            if (newActivity.ActivityContactID == -1)
                updateCmd.Parameters.AddWithValue("@NewActivityContactID", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewActivityContactID", newActivity.ActivityContactID);
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
    }
}