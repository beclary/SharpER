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
        private string activityJobPosition;
        private int activityContactID; // Foreign key to the Contact class
        private string activityContactFirstName;
        private int activityCompanyID; // Foreign key to the Company class
        private string activityCompanyName;
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
                activityDate = value.Date;
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

        public string ActivityJobPosition
        {
            get
            {
                return activityJobPosition;
            }
            set
            {
                activityJobPosition = value;
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

        public string ActivityContactFirstName
        {
            get
            {
                return activityContactFirstName;
            }
            set
            {
                activityContactFirstName = value;
            }
        }

        public int ActivityCompanyID
        {
            get
            {
                return activityCompanyID;
            }
            set
            {
                activityCompanyID = value;
            }
        }

        public string ActivityCompanyName
        {
            get
            {
                return activityCompanyName;
            }
            set
            {
                activityCompanyName = value;
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
