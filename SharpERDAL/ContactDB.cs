// ContactDB Data Access Layer (DAL) for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;


namespace SharpERDAL
{
    public static class ContactDB
    {
        /// <summary>
        /// This will provide a listing of all the customers in the database
        /// </summary>
        /// <returns>a listing of all the customers using a list T</returns>
        public static List<Contact> GetAllContacts()
        {
            List<Contact> contactList = new List<Contact>();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT * " +
                "FROM Contact " +
                "ORDER BY ContactID";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int conContactIDOrd = readur.GetOrdinal("ContactID");
                int conContactFirstNameOrd = readur.GetOrdinal("ContactFirstName");
                int conContactLastNameOrd = readur.GetOrdinal("ContactLastName");
                int conContactTitleOrd = readur.GetOrdinal("ContactTitle");
                int conContactDepartmentOrd = readur.GetOrdinal("ContactDepartment");
                int conContactAddressOrd = readur.GetOrdinal("ContactAddress");
                int conContactCityOrd = readur.GetOrdinal("ContactCity");
                int conContactStateOrd = readur.GetOrdinal("ContactState");
                int conContactZipCodeOrd = readur.GetOrdinal("ContactZipCode");
                int conContactPhoneOrd = readur.GetOrdinal("ContactPhone");
                int conContactMobileOrd = readur.GetOrdinal("ContactMobile");
                int conContactFaxOrd = readur.GetOrdinal("ContactFax");
                int conContactEmailOrd = readur.GetOrdinal("ContactEmail");
                int conContactContactedViaOrd = readur.GetOrdinal("ContactContactedVia");
                int conContactNotesOrd = readur.GetOrdinal("ContactNotes");

                while (readur.Read())
                {
                    Contact conRowInfo = new Contact();
                    conRowInfo.ContactID = readur.GetInt32(conContactIDOrd);
                    conRowInfo.ContactFirstName = readur.GetString(conContactFirstNameOrd);
                    conRowInfo.ContactLastName = readur.GetString(conContactLastNameOrd);
                    conRowInfo.ContactTitle = readur.GetString(conContactTitleOrd);
                    conRowInfo.ContactDepartment = readur.GetString(conContactDepartmentOrd);
                    conRowInfo.ContactAddress = readur.GetString(conContactAddressOrd);
                    conRowInfo.ContactCity = readur.GetString(conContactCityOrd);
                    conRowInfo.ContactState = readur.GetString(conContactStateOrd);
                    conRowInfo.ContactZipCode = readur.GetString(conContactZipCodeOrd);
                    conRowInfo.ContactPhone = readur.GetString(conContactPhoneOrd);
                    conRowInfo.ContactMobile = readur.GetString(conContactMobileOrd);
                    conRowInfo.ContactFax = readur.GetString(conContactFaxOrd);
                    conRowInfo.ContactEmail = readur.GetString(conContactEmailOrd);
                    conRowInfo.ContactContactedVia = readur.GetString(conContactContactedViaOrd);
                    conRowInfo.ContactNotes = readur.GetString(conContactNotesOrd);
                    contactList.Add(conRowInfo);
                }
                readur.Close();
            }
            catch (SqlException xsept)
            {
                throw xsept;
            }
            catch (Exception xsept)
            {
                throw xsept;
            }
            finally
            {
                conn.Close();
            }
            return contactList;
        }

        /// <summary>
        /// This will provide the Contact information given a specific contactID
        /// </summary>
        public static Contact GetSpecificContactInfo(int contactID)
        {
            Contact specificContact = new Contact();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT ContactID, ContactFirstName, ContactLastName, ContactTitle, ContactDepartment, ContactAddress, ContactCity, ContactState, ContactZipCode, ContactContactedVia, ContactPhone, ContactMobile, ContactFax, ContactEmail, ContactNotes " +
                "FROM Contact " +
                "WHERE ContactID = @ContactID";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            selectCmd.Parameters.AddWithValue("@ContactID", contactID);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int conContactIDOrd = readur.GetOrdinal("ContactID");
                int conContactFirstNameOrd = readur.GetOrdinal("ContactFirstName");
                int conContactLastNameOrd = readur.GetOrdinal("ContactLastName");
                int conContactTitleOrd = readur.GetOrdinal("ContactTitle");
                int conContactDepartmentOrd = readur.GetOrdinal("ContactDepartment");
                int conContactAddressOrd = readur.GetOrdinal("ContactAddress");
                int conContactCityOrd = readur.GetOrdinal("ContactCity");
                int conContactStateOrd = readur.GetOrdinal("ContactState");
                int conContactZipCodeOrd = readur.GetOrdinal("ContactZipCode");
                int conContactContactedViaOrd = readur.GetOrdinal("ContactContactedVia");
                int conContactPhoneOrd = readur.GetOrdinal("ContactPhone");
                int conContactMobileOrd = readur.GetOrdinal("ContactMobile");
                int conContactFaxOrd = readur.GetOrdinal("ContactFax");
                int conContactEmailOrd = readur.GetOrdinal("ContactEmail");
                int conContactNotesOrd = readur.GetOrdinal("ContactNotes");

                while (readur.Read())
                {
                    Contact specificContactRowInfo = new Contact();
                    specificContactRowInfo.ContactID = readur.GetInt32(conContactIDOrd);
                    specificContactRowInfo.ContactFirstName = readur.GetString(conContactFirstNameOrd);
                    specificContactRowInfo.ContactLastName = readur.GetString(conContactLastNameOrd);
                    specificContactRowInfo.ContactTitle = readur.GetString(conContactTitleOrd);
                    specificContactRowInfo.ContactDepartment = readur.GetString(conContactDepartmentOrd);
                    specificContactRowInfo.ContactAddress = readur.GetString(conContactAddressOrd);
                    specificContactRowInfo.ContactCity = readur.GetString(conContactCityOrd);
                    specificContactRowInfo.ContactState = readur.GetString(conContactStateOrd);
                    specificContactRowInfo.ContactZipCode = readur.GetString(conContactZipCodeOrd);
                    specificContactRowInfo.ContactContactedVia = readur.GetString(conContactContactedViaOrd);
                    specificContactRowInfo.ContactPhone = readur.GetString(conContactPhoneOrd);
                    specificContactRowInfo.ContactMobile = readur.GetString(conContactMobileOrd);
                    specificContactRowInfo.ContactFax = readur.GetString(conContactFaxOrd);
                    specificContactRowInfo.ContactEmail = readur.GetString(conContactEmailOrd);
                    specificContactRowInfo.ContactNotes = readur.GetString(conContactNotesOrd);
                }
                readur.Close();
            }
            catch (SqlException xsept)
            {
                throw xsept;
            }
            catch (Exception xsept)
            {
                throw xsept;
            }
            finally
            {
                conn.Close();
            }
            return specificContact;
        }
    }
}