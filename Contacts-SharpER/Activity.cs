// ACTIVITY Business Logic Layer (BLL) for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SharpERBLL    // This is the namespace for all of the BLL classes
{
    public class Activity
    {
        // DATA MEMBER DECLARATIONS
        private int activityID; // Primary key
        private DateTime activityDate;
        private string activityDescription;
        private string activityTravel;
        private int activityJobID; // Foreign key to the Job class
        private int activityContactID; // Foreign key to the Contact class
        private string activityNotes;

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Activity()
        {
            // no body. Default constructor
        }

        // PROPERTIES
        public int ActivityID
        {
            get
            {
                return activityID;
            }

            set
            {
                activityID = value;
            }
        }

        public DateTime ActivityDate
        {
            get
            {
                return activityDate;
            }

            set
            {
                activityDate = value;
            }
        }

        public string ActivityDescription
        {
            get
            {
                return activityDescription;
            }

            set
            {
                activityDescription = value;
            }
        }

        public string ActivityTravel
        {
            get
            {
                return activityTravel;
            }

            set
            {
                activityTravel = value;
            }
        }

        public int ActivityJobID
        {
            get
            {
                return activityJobID;
            }

            set
            {
                activityJobID = value;
            }
        }
        public int ActivityContactID
        {
            get
            {
                return activityContactID;
            }

            set
            {
                activityContactID = value;
            }
        }

        public string ActivityNotes
        {
            get
            {
                return activityNotes;
            }

            set
            {
                activityNotes = value;
            }
        }
    }
}
