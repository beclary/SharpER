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

        public static bool UpdateModifyContact (Contact oldContact, Contact newContact)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string updateStmt =
                "UPDATE Contact SET " +
                "ContactFirstName = @NewContactFirstName, " +
                "ContactLastName = @NewContactLastName, " +
                "ContactTitle = @NewContactTitle, " +
                "ContactDepartment = @NewContactDepartment, " +
                "ContactAddress = @NewContactAddress, " +
                "ContactCity = @NewContactCity, " +
                "ContactState = @NewContactState, " +
                "ContactZipCode = @NewContactZipCode, " +
                "ContactPhone = @NewContactPhone, " +
                "ContactMobile = @NewContactMobile, " +
                "ContactFax = @NewContactFax, " +
                "ContactEmail = @NewContactEmail, " +
                "ContactContactedVia = @NewContactContactedVia, " +
                "ContactNotes = @NewContactNotes " +
                "WHERE ContactID = @OldContactID " +
                "AND ContactFirstName = @OldContactFirstName " +
                "AND ContactLastName = @OldContactLastName " +
                "AND (ContactTitle = @OldContactTitle " +
                    "OR ContactTitle IS NULL AND @OldContactTitle IS NULL) " +
                "AND (ContactDepartment = @OldContactDepartment " +
                    "OR ContactDepartment IS NULL AND @OldContactDepartment IS NULL) " +
                "AND ContactAddress = @OldContactAddress " +
                "AND ContactCity = @OldContactCity " +
                "AND ContactState = @OldContactState " +
                "AND ContactZipCode = @OldContactZipCode " +
                "AND (ContactPhone = @OldContactPhone " +
                    "OR ContactPhone IS NULL AND @OldContactPhone IS NULL) " +
                "AND (ContactMobile = @OldContactMobile " +
                    "OR ContactMobile IS NULL AND @OldContactMobile IS NULL) " +
                "AND (ContactFax = @OldContactFax " +
                    "OR ContactFax IS NULL AND @OldContactFax IS NULL) " +
                "AND (ContactEmail = @OldContactEmail " +
                    "OR ContactEmail IS NULL AND @OldContactEmail IS NULL) " +
                "AND (ContactContactedVia = @OldContactContactedVia " +
                    "OR ContactContactedVia IS NULL AND @OldContactContactedVia IS NULL) " +
                "AND ContactNotes = @OldContactNotes " +
                    "OR ContactNotes IS NULL AND @OldContactNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);
            // NewContact changes
            updateCmd.Parameters.AddWithValue("@NewContactFirstName", newContact.ContactFirstName);
            updateCmd.Parameters.AddWithValue("@NewContactLastName", newContact.ContactLastName);
            if (newContact.ContactTitle == "")
                updateCmd.Parameters.AddWithValue("@NewContactTitle", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewContactTitle", newContact.ContactTitle);
            if (newContact.ContactDepartment == "")
                updateCmd.Parameters.AddWithValue("@NewContactDepartment", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewContactDepartment", newContact.ContactDepartment);
            updateCmd.Parameters.AddWithValue("@NewContactAddress", newContact.ContactAddress);
            updateCmd.Parameters.AddWithValue("@NewContactCity", newContact.ContactCity);
            updateCmd.Parameters.AddWithValue("@NewContactState", newContact.ContactState);
            updateCmd.Parameters.AddWithValue("@NewContactZipCode", newContact.ContactZipCode);
            if (newContact.ContactPhone == "")
                updateCmd.Parameters.AddWithValue("@NewContactPhone", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewContactPhone", newContact.ContactPhone);
            if (newContact.ContactMobile == "")
                updateCmd.Parameters.AddWithValue("@NewContactMobile", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewContactMobile", newContact.ContactMobile);
            if (newContact.ContactFax == "")
                updateCmd.Parameters.AddWithValue("@NewContactFax", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewContactFax", newContact.ContactFax);
            if (newContact.ContactEmail == "")
                updateCmd.Parameters.AddWithValue("@NewContactEmail", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewContactEmail", newContact.ContactEmail);
            if (newContact.ContactContactedVia == "")
                updateCmd.Parameters.AddWithValue("@NewContactContactedVia", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewContactContactedVia", newContact.ContactContactedVia);
            if (newContact.ContactNotes == "")
                updateCmd.Parameters.AddWithValue("@NewContactNotes", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewContactNotes", newContact.ContactNotes);
            // OldContact changes
            updateCmd.Parameters.AddWithValue("@OldContactFirstName", oldContact.ContactFirstName);
            updateCmd.Parameters.AddWithValue("@OldContactLastName", oldContact.ContactLastName);
            if (oldContact.ContactTitle == "")
                updateCmd.Parameters.AddWithValue("@OldContactTitle", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldContactTitle", oldContact.ContactTitle);
            if (oldContact.ContactDepartment == "")
                updateCmd.Parameters.AddWithValue("@OldContactDepartment", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldContactDepartment", oldContact.ContactDepartment);
            updateCmd.Parameters.AddWithValue("@OldContactAddress", oldContact.ContactAddress);
            updateCmd.Parameters.AddWithValue("@OldContactCity", oldContact.ContactCity);
            updateCmd.Parameters.AddWithValue("@OldContactState", oldContact.ContactState);
            updateCmd.Parameters.AddWithValue("@OldContactZipCode", oldContact.ContactZipCode);
            if (oldContact.ContactPhone == "")
                updateCmd.Parameters.AddWithValue("@OldContactPhone", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldContactPhone", oldContact.ContactPhone);
            if (oldContact.ContactMobile == "")
                updateCmd.Parameters.AddWithValue("@OldContactMobile", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldContactMobile", oldContact.ContactMobile);
            if (oldContact.ContactFax == "")
                updateCmd.Parameters.AddWithValue("@OldContactFax", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldContactFax", oldContact.ContactFax);
            if (oldContact.ContactEmail == "")
                updateCmd.Parameters.AddWithValue("@OldContactEmail", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldContactEmail", oldContact.ContactEmail);
            if (oldContact.ContactContactedVia == "")
                updateCmd.Parameters.AddWithValue("@OldContactContactedVia", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldContactContactedVia", oldContact.ContactContactedVia);
            if (oldContact.ContactNotes == "")
                updateCmd.Parameters.AddWithValue("@OldContactNotes", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldContactNotes", oldContact.ContactNotes);

            try
            {
                conn.Open();
                int count = updateCmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch(SqlException xsept)
            {
                throw xsept;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}