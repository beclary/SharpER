// Contact.cs Business Logic Layer (BLL) for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SharpERBLL    // This is the namespace for all of the BLL classes
{
    public class Contact
    {
        // DATA MEMBER DECLARATIONS
        private int contactID; // Primary key
        private string contactFirstName;
        private string contactLastName;
        private string contactTitle;
        private string contactDepartment;
        private string contactAddress;
        private string contactCity;
        private string contactState;
        private string contactZipCode;
        private string contactPhone;
        private string contactMobile;
        private string contactFax;
        private string contactEmail;
        private string contactContactedVia;
        private string contactNotes;

        // CONSTRUCTORS
        /// <summary>
        /// Default constructor
        /// </summary>
        public Contact()
        {
            // no body. Default constructor
        }


        // PROPERTIES
        public int ContactID
        {
            get
            {
                return contactID;
            }

            set
            {
                contactID = value;
            }
        }

        public string ContactFirstName
        {
            get
            {
                return contactFirstName;
            }

            set
            {
                contactFirstName = value;
            }
        }

        public string ContactLastName
        {
            get
            {
                return contactLastName;
            }

            set
            {
                contactLastName = value;
            }
        }

        public string ContactTitle
        {
            get
            {
                return contactTitle;
            }

            set
            {
                contactTitle = value;
            }
        }

        public string ContactDepartment
        {
            get
            {
                return contactDepartment;
            }

            set
            {
                contactDepartment = value;
            }
        }

        public string ContactAddress
        {
            get
            {
                return contactAddress;
            }

            set
            {
                contactAddress = value;
            }
        }

        public string ContactCity
        {
            get
            {
                return contactCity;
            }

            set
            {
                contactCity = value;
            }
        }

        public string ContactState
        {
            get
            {
                return contactState;
            }

            set
            {
                contactState = value;
            }
        }

        public string ContactZipCode
        {
            get
            {
                return contactZipCode;
            }

            set
            {
                contactZipCode = value;
            }
        }

        public string ContactPhone
        {
            get
            {
                return contactPhone;
            }

            set
            {
                contactPhone = value;
            }
        }

        public string ContactMobile
        {
            get
            {
                return contactMobile;
            }

            set
            {
                contactMobile = value;
            }
        }

        public string ContactFax
        {
            get
            {
                return contactFax;
            }

            set
            {
                contactFax = value;
            }
        }

        public string ContactEmail
        {
            get
            {
                return contactEmail;
            }

            set
            {
                contactEmail = value;
            }
        }

        public string ContactContactedVia
        {
            get
            {
                return contactContactedVia;
            }

            set
            {
                contactContactedVia = value;
            }
        }

        public string ContactNotes
        {
            get
            {
                return contactNotes;
            }

            set
            {
                contactNotes = value;
            }
        }

        public string GetFullName()
        {
            string fullName = ContactFirstName + " " + ContactLastName;
            return fullName;
        }



    }
}