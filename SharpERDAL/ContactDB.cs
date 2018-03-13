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
        // This will provide a listing of all the customers in the database
        // This returns a listing of all the customers using a list T
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

                readur.Read();
                    if (readur[conContactIDOrd] == DBNull.Value)
                        specificContact = null;
                    else
                        specificContact.ContactID = readur.GetInt32(conContactIDOrd);
                    if (readur[conContactFirstNameOrd] == DBNull.Value)
                        specificContact.ContactFirstName = null;
                    else
                        specificContact.ContactFirstName = readur.GetString(conContactFirstNameOrd);
                    if (readur[conContactLastNameOrd] == DBNull.Value)
                        specificContact.ContactLastName = null;
                    else
                        specificContact.ContactLastName = readur.GetString(conContactLastNameOrd);
                    if (readur[conContactTitleOrd] == DBNull.Value)
                        specificContact.ContactTitle = null;
                    else
                        specificContact.ContactTitle = readur.GetString(conContactTitleOrd);
                    if (readur[conContactDepartmentOrd] == DBNull.Value)
                        specificContact.ContactDepartment = null;
                    else
                        specificContact.ContactDepartment = readur.GetString(conContactDepartmentOrd);
                    if (readur[conContactAddressOrd] == DBNull.Value)
                        specificContact.ContactAddress = null;
                    else
                        specificContact.ContactAddress = readur.GetString(conContactAddressOrd);
                    if (readur[conContactCityOrd] == DBNull.Value)
                        specificContact.ContactCity = null;
                    else
                        specificContact.ContactCity = readur.GetString(conContactCityOrd);
                    if (readur[conContactStateOrd] == DBNull.Value)
                        specificContact.ContactState = null;
                    else
                        specificContact.ContactState = readur.GetString(conContactStateOrd);
                    if (readur[conContactZipCodeOrd] == DBNull.Value)
                        specificContact.ContactZipCode = null;
                    else
                        specificContact.ContactZipCode = readur.GetString(conContactZipCodeOrd);
                    if (readur[conContactContactedViaOrd] == DBNull.Value)
                        specificContact.ContactContactedVia = null;
                    else
                        specificContact.ContactContactedVia = readur.GetString(conContactContactedViaOrd);
                    if (readur[conContactPhoneOrd] == DBNull.Value)
                        specificContact.ContactPhone = null;
                    else
                        specificContact.ContactPhone = readur.GetString(conContactPhoneOrd);
                    if (readur[conContactMobileOrd] == DBNull.Value)
                        specificContact.ContactMobile = null;
                    else
                        specificContact.ContactMobile = readur.GetString(conContactMobileOrd);
                    if (readur[conContactFaxOrd] == DBNull.Value)
                        specificContact.ContactFax = null;
                    else
                        specificContact.ContactFax = readur.GetString(conContactFaxOrd);
                    if (readur[conContactEmailOrd] == DBNull.Value)
                        specificContact.ContactEmail = null;
                    else
                        specificContact.ContactEmail = readur.GetString(conContactEmailOrd);
                    if (readur[conContactNotesOrd] == DBNull.Value)
                        specificContact.ContactNotes = null;
                    else
                        specificContact.ContactNotes = readur.GetString(conContactNotesOrd);
                readur.Close();
                return specificContact;
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
                "AND (con_first_name = @OldContactFirstName " +
                    "OR con_first_name IS NULL AND @OldContactFirstName IS NULL)" +
                "AND (con_last_name = @OldContactLastName " +
                    "OR con_last_name IS NULL AND @OldContactLastName IS NULL)" +
                "AND (con_title = @OldContactTitle " +
                    "OR con_title IS NULL AND @OldContactTitle IS NULL) " +
                "AND (con_department = @OldContactDepartment " +
                    "OR con_department IS NULL AND @OldContactDepartment IS NULL) " +
                "AND (con_address = @OldContactAddress " +
                    "OR con_address IS NULL AND @OldContactAddress IS NULL)" +
                "AND (con_city = @OldContactCity " +
                    "OR con_city IS NULL AND @OldContactCity IS NULL)" +
                "AND (con_state = @OldContactState " +
                    "OR con_state IS NULL AND @OldContactState IS NULL)" +
                "AND (con_zip_code = @OldContactZipCode " +
                    "OR con_zip_code IS NULL AND @OldContactZipCode IS NULL)" +
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
                "AND (con_notes = @OldContactNotes " +
                    "OR con_notes IS NULL AND @OldContactNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);
            // NewContact changes
            if (newContact.ContactFirstName == "")
            {
                updateCmd.Parameters.AddWithValue("@NewContactFirstName", DBNull.Value);
                updateCmd.Parameters["@NewContactFirstName"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactFirstName", newContact.ContactFirstName); 
            if (newContact.ContactLastName == "")
            {
                updateCmd.Parameters.AddWithValue("@NewContactLastName", DBNull.Value);
                updateCmd.Parameters["@NewContactLastName"].IsNullable = true;
            }      
            else
                updateCmd.Parameters.AddWithValue("@NewContactLastName", newContact.ContactLastName);         
            if (newContact.ContactTitle == "")                                                           
            {
                updateCmd.Parameters.AddWithValue("@NewContactTitle", DBNull.Value);
                updateCmd.Parameters["@NewContactTitle"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactTitle", newContact.ContactTitle);
            if (newContact.ContactDepartment == "")                                                      
            {
                updateCmd.Parameters.AddWithValue("@NewContactDepartment", DBNull.Value);
                updateCmd.Parameters["@NewContactDepartment"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactDepartment", newContact.ContactDepartment);
            if (newContact.ContactAddress == "")                                                            
            {
                updateCmd.Parameters.AddWithValue("@NewContactAddress", DBNull.Value);
                updateCmd.Parameters["@NewContactAddress"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactAddress", newContact.ContactAddress);
            if (newContact.ContactCity == "")                                                               
            {
                updateCmd.Parameters.AddWithValue("@NewContactCity", DBNull.Value);
                updateCmd.Parameters["@NewContactCity"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactCity", newContact.ContactCity);
            if (newContact.ContactState == "")                                                              
            {
                updateCmd.Parameters.AddWithValue("@NewContactState", DBNull.Value);
                updateCmd.Parameters["@NewContactState"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactState", newContact.ContactState);
            if (newContact.ContactZipCode == "")                                                        
            {
                updateCmd.Parameters.AddWithValue("@NewContactZipCode", DBNull.Value);
                updateCmd.Parameters["@NewContactZipCode"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactZipCode", newContact.ContactZipCode);
            if (newContact.ContactPhone == "")                                                             
            {
                updateCmd.Parameters.AddWithValue("@NewContactPhone", DBNull.Value);
                updateCmd.Parameters["@NewContactPhone"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactPhone", newContact.ContactPhone);
            if (newContact.ContactMobile == "")                                                          
            {
                updateCmd.Parameters.AddWithValue("@NewContactMobile", DBNull.Value);
                updateCmd.Parameters["@NewContactMobile"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactMobile", newContact.ContactMobile);
            if (newContact.ContactFax == "")                                                            
            {
                updateCmd.Parameters.AddWithValue("@NewContactFax", DBNull.Value);
                updateCmd.Parameters["@NewContactFax"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactFax", newContact.ContactFax);
            if (newContact.ContactEmail == "")                                                             
            {
                updateCmd.Parameters.AddWithValue("@NewContactEmail", DBNull.Value);
                updateCmd.Parameters["@NewContactEmail"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactEmail", newContact.ContactEmail);
            if (newContact.ContactContactedVia == "")                                                     
            {
                updateCmd.Parameters.AddWithValue("@NewContactContactedVia", DBNull.Value);
                updateCmd.Parameters["@NewContactContactedVia"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactContactedVia", newContact.ContactContactedVia);
            if (newContact.ContactNotes == "")                                                             
            {
                updateCmd.Parameters.AddWithValue("@NewContactNotes", DBNull.Value);
                updateCmd.Parameters["@NewContactNotes"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@NewContactNotes", newContact.ContactNotes);
            // OldContact changes
            updateCmd.Parameters.AddWithValue("@OldContactID", oldContact.ContactID);

            if (oldContact.ContactFirstName == "")
            {
                updateCmd.Parameters.AddWithValue("@OldContactFirstName", DBNull.Value);
                updateCmd.Parameters["@OldContactFirstName"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactFirstName", oldContact.ContactFirstName);
            if (oldContact.ContactLastName == "")
            {
                updateCmd.Parameters.AddWithValue("@OldContactLastName", DBNull.Value);
                updateCmd.Parameters["@OldContactLastName"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactLastName", oldContact.ContactLastName);
            if (oldContact.ContactTitle == "")
            {
                updateCmd.Parameters.AddWithValue("@OldContactTitle", DBNull.Value);
                updateCmd.Parameters["@OldContactTitle"].IsNullable = true;        
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactTitle", oldContact.ContactTitle);
            if (oldContact.ContactDepartment == "")                                                        
            {
                updateCmd.Parameters.AddWithValue("@OldContactDepartment", DBNull.Value);
                updateCmd.Parameters["@NewContactDepartment"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactDepartment", oldContact.ContactDepartment);
            if (oldContact.ContactAddress == "")                                                        
            {
                updateCmd.Parameters.AddWithValue("@OldContactAddress", DBNull.Value);
                updateCmd.Parameters["@OldContactAddress"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactAddress", oldContact.ContactAddress);
            if (oldContact.ContactCity == "")                                                             
            {
                updateCmd.Parameters.AddWithValue("@OldContactCity", DBNull.Value);
                updateCmd.Parameters["@OldContactCity"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactCity", oldContact.ContactCity);
            if (oldContact.ContactState == "")                                                            
            {
                updateCmd.Parameters.AddWithValue("@OldContactState", DBNull.Value);
                updateCmd.Parameters["@OldContactState"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactState", oldContact.ContactState);
            if (oldContact.ContactZipCode == "")                                                           
            {
                updateCmd.Parameters.AddWithValue("@OldContactZipCode", DBNull.Value);
                updateCmd.Parameters["@OldContactZipCode"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactZipCode", oldContact.ContactZipCode);
            if (oldContact.ContactPhone == "")                                                             
            {
                updateCmd.Parameters.AddWithValue("@OldContactPhone", DBNull.Value);
                updateCmd.Parameters["@OldContactPhone"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactPhone", oldContact.ContactPhone);
            if (oldContact.ContactMobile == "")                                                           
            {
                updateCmd.Parameters.AddWithValue("@OldContactMobile", DBNull.Value);
                updateCmd.Parameters["@OldContactMobile"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactMobile", oldContact.ContactMobile);
            if (oldContact.ContactFax == "")                                                        
            {
                updateCmd.Parameters.AddWithValue("@OldContactFax", DBNull.Value);
                updateCmd.Parameters["@OldContactFax"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactFax", oldContact.ContactFax);
            if (oldContact.ContactEmail == "")                                                            
            {
                updateCmd.Parameters.AddWithValue("@OldContactEmail", DBNull.Value);
                updateCmd.Parameters["@OldContactEmail"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactEmail", oldContact.ContactEmail);
            if (oldContact.ContactContactedVia == "")                                                    
            {
                updateCmd.Parameters.AddWithValue("@OldContactContactedVia", DBNull.Value);
                updateCmd.Parameters["@OldContactContactedVia"].IsNullable = true;
            }
            else
                updateCmd.Parameters.AddWithValue("@OldContactContactedVia", oldContact.ContactContactedVia);
            if (oldContact.ContactNotes == "")                                                           
            {
                updateCmd.Parameters.AddWithValue("@OldContactNotes", DBNull.Value);
                updateCmd.Parameters["@OldContactNotes"].IsNullable = true;
            }
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

        // This is the method to add a contact
        public static int AddContact (Contact newContact)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string insertStmt =
                "INSERT INTO Contact " +
                "(con_first_name, con_last_name, con_title, con_department, " +
                "con_address, con_city, con_state, con_zip_code, con_contacted_via, " +
                "con_phone, con_mobile, con_fax, con_email, con_notes) " +
                "VALUES (@ContactFirstName, @ContactLastName, @ContactTitle, @ContactDepartment, " +
                "@ContactAddress, @ContactCity, @ContactState, @ContactZipCode, @ContactContactedVia, @ContactPhone, @ContactMobile, @ContactFax, @ContactEmail, @ContactNotes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);
            if (newContact.ContactFirstName == null)
            {
                insertCmd.Parameters.AddWithValue("@ContactFirstName", DBNull.Value);
                insertCmd.Parameters["@ContactFirstName"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactFirstName", newContact.ContactFirstName); 
            if (newContact.ContactLastName == null)
            {
                insertCmd.Parameters.AddWithValue("@ContactLastName", DBNull.Value);
                insertCmd.Parameters["@ContactLastName"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactLastName", newContact.ContactLastName);         
            if (newContact.ContactTitle == null)                                                      
            {
                insertCmd.Parameters.AddWithValue("@ContactTitle", DBNull.Value);
                insertCmd.Parameters["@ContactTitle"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactTitle", newContact.ContactTitle);
            if (newContact.ContactDepartment == null)                                                   
            {
                insertCmd.Parameters.AddWithValue("@ContactDepartment", DBNull.Value);
                insertCmd.Parameters["@ContactDepartment"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactDepartment", newContact.ContactDepartment);
            if (newContact.ContactAddress == null)                                                      
            {
                insertCmd.Parameters.AddWithValue("@ContactAddress", DBNull.Value);
                insertCmd.Parameters["@ContactAddress"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactAddress", newContact.ContactAddress);
            if (newContact.ContactCity == null)                                                          
            {
                insertCmd.Parameters.AddWithValue("@ContactCity", DBNull.Value);
                insertCmd.Parameters["@ContactCity"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactCity", newContact.ContactCity);
            if (newContact.ContactState == null)                                                         
            {
                insertCmd.Parameters.AddWithValue("@ContactState", DBNull.Value);
                insertCmd.Parameters["@ContactState"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactState", newContact.ContactState);
            if (newContact.ContactZipCode == null)                                                       
            {
                insertCmd.Parameters.AddWithValue("@ContactZipCode", DBNull.Value);
                insertCmd.Parameters["@ContactZipCode"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactZipCode", newContact.ContactZipCode);
            if (newContact.ContactContactedVia == null)                                                  
            {
                insertCmd.Parameters.AddWithValue("@ContactContactedVia", DBNull.Value);
                insertCmd.Parameters["@ContactContactedVia"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactContactedVia", newContact.ContactContactedVia);
            if (newContact.ContactPhone == null)                                                          
            {
                insertCmd.Parameters.AddWithValue("@ContactPhone", DBNull.Value);
                insertCmd.Parameters["@ContactPhone"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactPhone", newContact.ContactPhone);
            if (newContact.ContactMobile == null)                                                       
            {
                insertCmd.Parameters.AddWithValue("@ContactMobile", DBNull.Value);
                insertCmd.Parameters["@ContactMobile"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactMobile", newContact.ContactMobile);
            if (newContact.ContactFax == null)                                                            
            {
                insertCmd.Parameters.AddWithValue("@ContactFax", DBNull.Value);
                insertCmd.Parameters["@ContactFax"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactFax", newContact.ContactFax);
            if (newContact.ContactEmail == null)                                                          
            {
                insertCmd.Parameters.AddWithValue("@ContactEmail", DBNull.Value);
                insertCmd.Parameters["@ContactEmail"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactEmail", newContact.ContactEmail);
            if (newContact.ContactNotes == null)                                                        
            {
                insertCmd.Parameters.AddWithValue("@ContactNotes", DBNull.Value);
                insertCmd.Parameters["@ContactNotes"].IsNullable = true;
            }
            else
                insertCmd.Parameters.AddWithValue("@ContactNotes", newContact.ContactNotes);

            try
            {
                conn.Open();
                insertCmd.ExecuteNonQuery();
                string selectStmt =
                    "SELECT IDENT_CURRENT('Contact') FROM Contact";
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

        // This is the method to delete a contact
        public static int DeleteContact(int contactID)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "DELETE FROM Contact " +
                "WHERE con_id = @ContactID";
            SqlCommand deleteCmd = new SqlCommand(selectStmt, conn);
            deleteCmd.Parameters.AddWithValue("@ContactID", contactID);

            try
            {
                conn.Open();
                int rowDel = Convert.ToInt32(deleteCmd.ExecuteNonQuery());
                return rowDel;
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