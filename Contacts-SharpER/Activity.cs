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
    class Activity
    {
        private int activityID; // Primary key
        private DateTime activityDate;
        private string activityDescription;
        private string activityTravel;
        private int activityJobID; // Foreign key to the Job class
        private int activityContactID; // Foreign key to the Contact class
        private string activityNotes;

        public Activity()
        {
            throw new System.NotImplementedException();
        }

        public int ActivityContactID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public DateTime ActivityDate
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string ActivityDescription
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string ActivityTravel
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int ActivityJobID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int ActivityID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string ActivityNotes
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
