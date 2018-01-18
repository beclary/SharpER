// JOB Business Logic Layer (BLL) for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SharpERBLL    // This is the namespace for all of the BLL classes
{
    public class Job
    {
        // DATA MEMBER DECLARATIONS
        private int jobID; // Primary key
        private string jobPosition;
        private DateTime jobApplied;
        private decimal jobPay;
        private int jobContactID; // Foreign key to the Contact class
        private int jobCompanyID; // Foreign key to the Company class
        private string jobNotes;

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Job()
        {
            // no body. Default constructor
        }

        // PROPERTIES
        public int JobID
        {
            get
            {
                return jobID;
            }

            set
            {
                jobID = value;
            }
        }

        public string JobPosition
        {
            get
            {
                return jobPosition;
            }

            set
            {
                jobPosition = value;
            }
        }

        public DateTime JobApplied
        {
            get
            {
                return jobApplied;
            }

            set
            {
                jobApplied = value;
            }
        }

        public decimal JobPay
        {
            get
            {
                return jobPay;
            }

            set
            {
                jobPay = value;
            }
        }

        public int JobContactID
        {
            get
            {
                return jobContactID;
            }

            set
            {
                jobContactID = value;
            }
        }

        public int JobCompanyID
        {
            get
            {
                return jobCompanyID;
            }

            set
            {
                jobCompanyID = value;
            }
        }

        public string JobNotes
        {
            get
            {
                return jobNotes;
            }

            set
            {
                jobNotes = value;
            }
        }
    }
}
