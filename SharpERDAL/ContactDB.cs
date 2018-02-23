// ContactDB Data Access Layer (DAL) for SharpER
// Bruce Clary

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;
using System.Windows.Forms;


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
                "ORDER BY con_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            SqlDataReader readur = null;

            try
            {
                conn.Open();
                readur = selectCmd.ExecuteReader();
                int conContactIDOrd = readur.GetOrdinal("con_id");
                int conContactFirstNameOrd = readur.GetOrdinal("con_first_name");
                int conContactLastNameOrd = readur.GetOrdinal("con_last_name");
                int conContactTitleOrd = readur.GetOrdinal("con_title");
                int conContactDepartmentOrd = readur.GetOrdinal("con_department");
                int conContactAddressOrd = readur.GetOrdinal("con_address");
                int conContactCityOrd = readur.GetOrdinal("con_city");
                int conContactStateOrd = readur.GetOrdinal("con_state");
                int conContactZipCodeOrd = readur.GetOrdinal("con_zip_code");
                int conContactPhoneOrd = readur.GetOrdinal("con_phone");
                int conContactMobileOrd = readur.GetOrdinal("con_mobile");
                int conContactFaxOrd = readur.GetOrdinal("con_fax");
                int conContactEmailOrd = readur.GetOrdinal("con_email");
                int conContactContactedViaOrd = readur.GetOrdinal("con_contacted_via");
                int conContactNotesOrd = readur.GetOrdinal("con_notes");

                while (readur.Read())
                {
                    Contact conRowInfo = new Contact();
                    if (readur[conContactIDOrd] == DBNull.Value)
                        conRowInfo.ContactID = -1;
                    else
                        conRowInfo.ContactID = readur.GetInt32(conContactIDOrd);
                    if (readur[conContactFirstNameOrd] == DBNull.Value)
                        conRowInfo.ContactFirstName = "";
                    else
                        conRowInfo.ContactFirstName = readur.GetString(conContactFirstNameOrd);
                    if (readur[conContactLastNameOrd] == DBNull.Value)
                        conRowInfo.ContactLastName = "";
                    else
                        conRowInfo.ContactLastName = readur.GetString(conContactLastNameOrd);
                    if (readur[conContactTitleOrd] == DBNull.Value)
                        conRowInfo.ContactTitle = "";
                    else
                        conRowInfo.ContactTitle = readur.GetString(conContactTitleOrd);
                    if (readur[conContactDepartmentOrd] == DBNull.Value)
                        conRowInfo.ContactDepartment = "";
                    else
                        conRowInfo.ContactDepartment = readur.GetString(conContactDepartmentOrd);
                    if (readur[conContactAddressOrd] == DBNull.Value)
                        conRowInfo.ContactAddress = "";
                    else
                        conRowInfo.ContactAddress = readur.GetString(conContactAddressOrd);
                    if (readur[conContactCityOrd] == DBNull.Value)
                        conRowInfo.ContactCity = "";
                    else
                        conRowInfo.ContactCity = readur.GetString(conContactCityOrd);
                    if (readur[conContactStateOrd] == DBNull.Value)
                        conRowInfo.ContactState = "";
                    else
                        conRowInfo.ContactState = readur.GetString(conContactStateOrd);
                    if (readur[conContactZipCodeOrd] == DBNull.Value)
                        conRowInfo.ContactZipCode = "";
                    else
                        conRowInfo.ContactZipCode = readur.GetString(conContactZipCodeOrd);
                    if (readur[conContactPhoneOrd] == DBNull.Value)
                        conRowInfo.ContactPhone = "";
                    else
                        conRowInfo.ContactPhone = readur.GetString(conContactPhoneOrd);
                    if (readur[conContactMobileOrd] == DBNull.Value)
                        conRowInfo.ContactMobile = "";
                    else
                        conRowInfo.ContactMobile = readur.GetString(conContactMobileOrd);
                    if (readur[conContactFaxOrd] == DBNull.Value)
                        conRowInfo.ContactFax = "";
                    else
                        conRowInfo.ContactFax = readur.GetString(conContactFaxOrd);
                    if (readur[conContactEmailOrd] == DBNull.Value)
                        conRowInfo.ContactEmail = "";
                    else
                        conRowInfo.ContactEmail = readur.GetString(conContactEmailOrd);
                    if (readur[conContactContactedViaOrd] == DBNull.Value)
                        conRowInfo.ContactContactedVia = "";
                    else
                        conRowInfo.ContactContactedVia = readur.GetString(conContactContactedViaOrd);
                    if (readur[conContactNotesOrd] == DBNull.Value)
                        conRowInfo.ContactNotes = "";
                    else
                        conRowInfo.ContactNotes = readur.GetString(conContactNotesOrd);
                    contactList.Add(conRowInfo);
                }
            }
            catch (SqlException xsept)
            {
                MessageBox.Show(xsept.Number + "\n" + xsept.Message);
                throw xsept;
            }
            catch (Exception xsept)
            {
                throw xsept;
            }
            finally
            {
                readur.Close();
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
                "SELECT con_id, con_first_name, con_last_name, con_title, con_department, con_address, con_city, con_state, con_zip_code, con_contacted_via, con_phone, con_mobile,  con_fax, con_email, con_notes " +
                "FROM Contact " +
                "WHERE con_id = @con_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            selectCmd.Parameters.AddWithValue("@con_id", contactID);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int conContactIDOrd = readur.GetOrdinal("con_id");
                int conContactFirstNameOrd = readur.GetOrdinal("con_first_name");
                int conContactLastNameOrd = readur.GetOrdinal("con_last_name");
                int conContactTitleOrd = readur.GetOrdinal("con_title");
                int conContactDepartmentOrd = readur.GetOrdinal("con_department");
                int conContactAddressOrd = readur.GetOrdinal("con_address");
                int conContactCityOrd = readur.GetOrdinal("con_city");
                int conContactStateOrd = readur.GetOrdinal("con_state");
                int conContactZipCodeOrd = readur.GetOrdinal("con_zip_code");
                int conContactContactedViaOrd = readur.GetOrdinal("con_contacted_via");
                int conContactPhoneOrd = readur.GetOrdinal("con_phone");
                int conContactMobileOrd = readur.GetOrdinal("con_mobile");
                int conContactFaxOrd = readur.GetOrdinal("con_fax");
                int conContactEmailOrd = readur.GetOrdinal("con_email");
                int conContactNotesOrd = readur.GetOrdinal("con_notes");

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

        // This is the method to update / modify a contact
        public static bool UpdateModifyContact (Contact oldContact, Contact newContact)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string updateStmt =
                "UPDATE Contact SET " +
                "con_first_name = @NewContactFirstName, " +
                "con_last_name = @NewContactLastName, " +
                "con_title = @NewContactTitle, " +
                "con_department = @NewContactDepartment, " +
                "con_address = @NewContactAddress, " +
                "con_city = @NewContactCity, " +
                "con_state = @NewContactState, " +
                "con_zip_code = @NewContactZipCode, " +
                "con_phone = @NewContactPhone, " +
                "con_mobile = @NewContactMobile, " +
                "con_fax = @NewContactFax, " +
                "con_email = @NewContactEmail, " +
                "con_contacted_via = @NewContactContactedVia, " +
                "con_notes = @NewContactNotes " +
                "WHERE con_id = @OldContactID " +
                "AND con_first_name = @OldContactFirstName " +
                "AND con_last_name = @OldContactLastName " +
                "AND (con_title = @OldContactTitle " +
                    "OR con_title IS NULL AND @OldContactTitle IS NULL) " +
                "AND (con_department = @OldContactDepartment " +
                    "OR con_department IS NULL AND @OldContactDepartment IS NULL) " +
                "AND con_address = @OldContactAddress " +
                "AND con_city = @OldContactCity " +
                "AND con_state = @OldContactState " +
                "AND con_zip_code = @OldContactZipCode " +
                "AND (con_phone = @OldContactPhone " +
                    "OR con_phone IS NULL AND @OldContactPhone IS NULL) " +
                "AND (con_mobile = @OldContactMobile " +
                    "OR con_mobile IS NULL AND @OldContactMobile IS NULL) " +
                "AND (con_fax = @OldContactFax " +
                    "OR con_fax IS NULL AND @OldContactFax IS NULL) " +
                "AND (con_email = @OldContactEmail " +
                    "OR con_email IS NULL AND @OldContactEmail IS NULL) " +
                "AND (con_contacted_via = @OldContactContactedVia " +
                    "OR con_contacted_via IS NULL AND @OldContactContactedVia IS NULL) " +
                "AND con_notes = @OldContactNotes " +
                    "OR con_notes IS NULL AND @OldContactNotes IS NULL)";
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

        // This is the method to add a contact
        public static int AddContact (Contact newContact)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string insertStmt =
                "INSERT Contact " +
                "(con_first_name, con_last_name, con_title, con_department, " +
                "con_address, con_city, con_state, con_zip_code, con_contacted_via, " +
                "con_phone, con_mobile, con_fax, con_email, con_notes) " +
                "VALUES (@ContactFirstName, @ContactLastName, @ContactTitle, @ContactDepartment, " +
                "@ContactAddress, @ContactCity, @ContactState, @ContactZipCode, @ContactContactedVia, @ContactPhone, @ContactMobile, @ContactFax, @ContactEmail, @ContactNotes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);
            insertCmd.Parameters.AddWithValue("@ContactFirstName", newContact.ContactFirstName);
            insertCmd.Parameters.AddWithValue("@ContactLastName", newContact.ContactLastName);
            if (newContact.ContactTitle == "")
                insertCmd.Parameters.AddWithValue("@ContactTitle", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ContactTitle", newContact.ContactTitle);
            if (newContact.ContactDepartment == "")
                insertCmd.Parameters.AddWithValue("@ContactDepartment", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ContactDepartment", newContact.ContactDepartment);
            insertCmd.Parameters.AddWithValue("@ContactAddress", newContact.ContactAddress);
            insertCmd.Parameters.AddWithValue("@ContactCity", newContact.ContactCity);
            insertCmd.Parameters.AddWithValue("@ContactState", newContact.ContactState);
            insertCmd.Parameters.AddWithValue("@ContactZipCode", newContact.ContactZipCode);
            insertCmd.Parameters.AddWithValue("@ContactContactedVia", newContact.ContactContactedVia);
            insertCmd.Parameters.AddWithValue("@ContactPhone", newContact.ContactPhone);
            if (newContact.ContactMobile == "")
                insertCmd.Parameters.AddWithValue("@ContactMobile", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ContactMobile", newContact.ContactMobile);
            if (newContact.ContactFax == "")
                insertCmd.Parameters.AddWithValue("@ContactFax", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ContactFax", newContact.ContactFax);
            if (newContact.ContactEmail == "")
                insertCmd.Parameters.AddWithValue("@ContactEmail", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ContactEmail", newContact.ContactEmail);
            if (newContact.ContactNotes == "")
                insertCmd.Parameters.AddWithValue("@ContactNotes", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@ContactNotes", newContact.ContactNotes);

            try
            {
                conn.Open();
                insertCmd.ExecuteNonQuery();
                string selectStmt =
                    "SELECT SCOPE_IDENTITY ('Contact') FROM Contact";
                SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
                int contactID = Convert.ToInt32(selectCmd.ExecuteScalar());
                return contactID;
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
        }
    }
}