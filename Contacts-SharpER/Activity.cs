using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_SharpER
{
    class Activity
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        private int activityID;
        private DateTime activityDate;
        private string activityDescription;
        private string activityTravel;
        /// <summary>
        /// Foreign Key
        /// </summary>
        private int activityJobID;
        /// <summary>
        /// Foreign Key
        /// </summary>
        private int activityContactID;
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
