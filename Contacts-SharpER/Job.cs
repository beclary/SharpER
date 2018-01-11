// JOB Business Logic Layer (BLL) for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SharpERBLL    // This is the namespace for all the BLL classes
{
    class Job
    {
        private int jobID;
        private string jobPosition;
        private DateTime jobApplied;
        private decimal jobPay;
        private int jobContactID;
        private int jobCompanyID;
        private string jobNotes;

        public int JobID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string JobPosition
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public DateTime JobApplied
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public decimal JobPay
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int JobContactID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int JobCompanyID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string JobNotes
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
