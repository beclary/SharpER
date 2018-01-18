using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;

namespace SharpERDAL
{
    public class ActivityDB
    {
        /// <summary>
        /// This will provide a listing of all the activities in the database
        /// </summary>
        public static List<Activity> GetAllActivities()
        {
            throw new System.NotImplementedException();
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