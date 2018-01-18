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
            throw new System.NotImplementedException();
        }
    }
}