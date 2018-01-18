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
        /// <summary>
        /// This will provide a listing of all the activities in the database
        /// </summary>
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
            finally
            {
                conn.Close();
            }
            return activityList;
        }

        /// <summary>
        /// This will provide a list of the activity that was done given a specific date
        /// </summary>
        public static Activity GetActivityByDate(DateTime activityDate)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This will provide the activity that was done given a specific activityID
        /// </summary>
        public static Activity GetSpecificActivityInfo(string activityID)
        {
            throw new System.NotImplementedException();
        }
    }
}