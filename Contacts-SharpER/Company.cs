// COMPANY Business Logic Layer (BLL) for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SharpERBLL    // This is the namespace for all of the BLL classes
{
    class Company
    {
        // DATA MEMBER DECLARATIONS
        private int companyID; // Primary key
        private string companyName;
        private string companyAddress;
        private string companyCity;
        private string companyState;
        private string companyZipCode;
        private string companyPhone;
        private string companyFax;
        private string companyWebsite;
        private string companyNotes;

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Company()
        {
            // no body. Default constructor
        }

        // PROPERTIES
        /// <summary></summary>
        public int CompanyID
        {
            get
            {
                return companyID;
            }

            set
            {
                companyID = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }

        public string CompanyAddress
        {
            get
            {
                return companyAddress;
            }

            set
            {
                companyAddress = value;
            }
        }

        public string CompanyCity
        {
            get
            {
                return companyCity;
            }

            set
            {
                companyCity = value;
            }
        }

        public string CompanyState
        {
            get
            {
                return companyState;
            }

            set
            {
                companyState = value;
            }
        }

        public string CompanyZipCode
        {
            get
            {
                return companyZipCode;
            }

            set
            {
                companyZipCode = value;
            }
        }

        public string CompanyPhone
        {
            get
            {
                return companyPhone;
            }

            set
            {
                companyPhone = value;
            }
        }

        public string CompanyFax
        {
            get
            {
                return companyFax;
            }

            set
            {
                companyFax = value;
            }
        }

        public string CompanyWebsite
        {
            get
            {
                return companyWebsite;
            }

            set
            {
                companyWebsite = value;
            }
        }

        public string CompanyNotes
        {
            get
            {
                return companyNotes;
            }

            set
            {
                companyNotes = value;
            }
        }
    }
}
