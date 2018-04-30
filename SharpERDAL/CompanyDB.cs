// CompanyDB Data Access Layer (DAL) for SharpER
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
    public static class CompanyDB
    {
        /// <summary>
        /// This will provide a listing of all companies in the database
        /// </summary>
        public static List<Company> GetAllCompanies()
        {
            List<Company> companyList = new List<Company>();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT * " +
                "FROM Company " +
                "ORDER BY com_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            SqlDataReader readur = null;

            try
            {
                conn.Open();
                readur = selectCmd.ExecuteReader();
                int comCompanyIDOrd = readur.GetOrdinal("com_id");
                int comCompanyNameOrd = readur.GetOrdinal("com_name");
                int comCompanyAddressOrd = readur.GetOrdinal("com_address");
                int comCompanyCityOrd = readur.GetOrdinal("com_city");
                int comCompanyStateOrd = readur.GetOrdinal("com_state");
                int comCompanyZipCodeOrd = readur.GetOrdinal("com_zip_code");
                int comCompanyPhoneOrd = readur.GetOrdinal("com_phone");
                int comCompanyFaxOrd = readur.GetOrdinal("com_fax");
                int comCompanyWebsiteOrd = readur.GetOrdinal("com_website");
                int comCompanyNotesOrd = readur.GetOrdinal("com_notes");

                while (readur.Read())
                {
                    Company comRowInfo = new Company();
                    if (readur[comCompanyIDOrd] == DBNull.Value)
                        comRowInfo.CompanyID = -1;
                    else
                        comRowInfo.CompanyID = readur.GetInt32(comCompanyIDOrd);
                    if (readur[comCompanyNameOrd] == DBNull.Value)
                        comRowInfo.CompanyName = "";
                    else
                        comRowInfo.CompanyName = readur.GetString(comCompanyNameOrd);
                    if (readur[comCompanyAddressOrd] == DBNull.Value)
                        comRowInfo.CompanyAddress = "";
                    else
                        comRowInfo.CompanyAddress = readur.GetString(comCompanyAddressOrd);
                    if (readur[comCompanyCityOrd] == DBNull.Value)
                        comRowInfo.CompanyCity = "";
                    else
                        comRowInfo.CompanyCity = readur.GetString(comCompanyCityOrd);
                    if (readur[comCompanyStateOrd] == DBNull.Value)
                        comRowInfo.CompanyState = "";
                    else
                        comRowInfo.CompanyState = readur.GetString(comCompanyStateOrd);
                    if (readur[comCompanyZipCodeOrd] == DBNull.Value)
                        comRowInfo.CompanyState = "";
                    else
                        comRowInfo.CompanyZipCode = readur.GetString(comCompanyZipCodeOrd);
                    if (readur[comCompanyPhoneOrd] == DBNull.Value)
                        comRowInfo.CompanyZipCode = "";
                    else
                        comRowInfo.CompanyPhone = readur.GetString(comCompanyPhoneOrd);
                    if (readur[comCompanyFaxOrd] == DBNull.Value)
                        comRowInfo.CompanyFax = "";
                    else
                        comRowInfo.CompanyFax = readur.GetString(comCompanyFaxOrd);
                    if (readur[comCompanyWebsiteOrd] == DBNull.Value)
                        comRowInfo.CompanyWebsite = "";
                    else
                        comRowInfo.CompanyWebsite = readur.GetString(comCompanyWebsiteOrd);
                    if (readur[comCompanyNotesOrd] == DBNull.Value)
                        comRowInfo.CompanyNotes = "";
                    else
                        comRowInfo.CompanyNotes = readur.GetString(comCompanyNotesOrd);
                    companyList.Add(comRowInfo);
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
            return companyList;
        }

        /// <summary>
        /// This will provide the Company information given a specific companyID
        /// </summary>
        public static Company GetSpecificCompanyInfo(int companyID)
        {
            Company specificCompany = new Company();
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "SELECT com_id, com_name, com_address, com_city, " +
                "com_state, com_zip_code, com_phone, com_fax, " +
                "com_website, com_notes " +
                "FROM Company " +
                "WHERE com_id = @com_id";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            selectCmd.Parameters.AddWithValue("@com_id", companyID);
            SqlDataReader readur = null;

            try
            {
                conn.Open();
                readur = selectCmd.ExecuteReader();
                int comCompanyIDOrd = readur.GetOrdinal("com_id");
                int comCompanyNameOrd = readur.GetOrdinal("com_name");
                int comCompanyAddressOrd = readur.GetOrdinal("com_address");
                int comCompanyCityOrd = readur.GetOrdinal("com_city");
                int comCompanyStateOrd = readur.GetOrdinal("com_state");
                int comCompanyZipCodeOrd = readur.GetOrdinal("com_zip_code");
                int comCompanyPhoneOrd = readur.GetOrdinal("com_phone");
                int comCompanyFaxOrd = readur.GetOrdinal("com_fax");
                int comCompanyWebsiteOrd = readur.GetOrdinal("com_website");
                int comCompanyNotesOrd = readur.GetOrdinal("com_notes");

                while (readur.Read())
                {
                    Company specificCompanyRowInfo = new Company();
                    if (readur[comCompanyIDOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyID = -1;
                    else
                        specificCompanyRowInfo.CompanyID = readur.GetInt32(comCompanyIDOrd);
                    if (readur[comCompanyNameOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyName = "";
                    else
                        specificCompanyRowInfo.CompanyName = readur.GetString(comCompanyNameOrd);
                    if (readur[comCompanyAddressOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyAddress = "";
                    else
                        specificCompanyRowInfo.CompanyAddress = readur.GetString(comCompanyAddressOrd);
                    if (readur[comCompanyCityOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyCity = "";
                    else
                        specificCompanyRowInfo.CompanyCity = readur.GetString(comCompanyCityOrd);
                    if (readur[comCompanyStateOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyState = "";
                    else
                        specificCompanyRowInfo.CompanyState = readur.GetString(comCompanyStateOrd);
                    if (readur[comCompanyZipCodeOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyZipCode = "";
                    else
                        specificCompanyRowInfo.CompanyZipCode = readur.GetString(comCompanyZipCodeOrd);
                    if (readur[comCompanyPhoneOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyPhone = "";
                    else
                        specificCompanyRowInfo.CompanyPhone = readur.GetString(comCompanyPhoneOrd);
                    if (readur[comCompanyFaxOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyFax = "";
                    else
                        specificCompanyRowInfo.CompanyFax = readur.GetString(comCompanyFaxOrd);
                    if (readur[comCompanyWebsiteOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyWebsite = "";
                    else
                        specificCompanyRowInfo.CompanyWebsite = readur.GetString(comCompanyWebsiteOrd);
                    if (readur[comCompanyNotesOrd] == DBNull.Value)
                        specificCompanyRowInfo.CompanyNotes = "";
                    else
                        specificCompanyRowInfo.CompanyNotes = readur.GetString(comCompanyNotesOrd);
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
            return specificCompany;
        }

        // Update/Modify method for Company
        public static bool UpdateModifyCompany(Company oldCompany, Company newCompany)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string updateStmt =
                "UPDATE Company SET " +
                "com_name = @NewCompanyName, " +
                "com_address = @NewCompanyAddress, " +
                "com_city = @NewCompanyCity, " +
                "com_state = @NewCompanyState, " +
                "com_zip_code = @NewCompanyZipCode, " +
                "com_phone = @NewCompanyPhone, " +
                "com_fax = @NewCompanyFax, " +
                "com_website = @NewCompanyWebsite, " +
                "com_notes = @NewCompanyNotes " +
                "WHERE com_id = @OldCompanyID " +
                "AND com_name = @OldCompanyName " +
                "AND com_address = @OldCompanyAddress " +
                "AND com_city = @OldCompanyCity " +
                "AND com_state = @OldCompanyState " +
                "AND com_zip_code = @OldCompanyZipCode " +
                "AND com_phone = @OldCompanyPhone " +
                "AND (com_fax = @OldCompanyFax " +
                    "OR com_fax IS NULL AND @OldCompanyFax IS NULL) " +
                "AND (com_website = @OldCompanyWebsite " +
                    "OR com_website IS NULL AND @OldCompanyWebsite IS NULL) " +
                "AND com_notes = @OldCompanyNotes " +
                    "OR com_notes IS NULL AND @OldCompanyNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);
            // New Company changes
            // Company Name
            if (newCompany.CompanyName == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyName", DBNull.Value);
                updateCmd.Parameters["@NewCompanyName"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyName", newCompany.CompanyName);
            }

            // Company Address
            if (newCompany.CompanyAddress == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyAddress", DBNull.Value);
                updateCmd.Parameters["@NewCompanyAddress"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyAddress", newCompany.CompanyAddress);
            }

            // Company City
            if (newCompany.CompanyCity == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyCity", DBNull.Value);
                updateCmd.Parameters["@NewCompanyCity"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyCity", newCompany.CompanyCity);
            }

            // Company State 
            if (newCompany.CompanyState == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyState", DBNull.Value);
                updateCmd.Parameters["@NewCompanyState"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyState", newCompany.CompanyState);
            }

            // Company ZipCode
            if (newCompany.CompanyZipCode == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyZipCode", DBNull.Value);
                updateCmd.Parameters["@NewCompanyZipCode"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyZipCode", newCompany.CompanyZipCode);
            }

            // Company Phone
            if (newCompany.CompanyPhone == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyZipCode", DBNull.Value);
                updateCmd.Parameters["@NewCompanyZipCode"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyPhone", newCompany.CompanyPhone);
            }

            // Company Fax
            if (newCompany.CompanyFax == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyFax", DBNull.Value);
                updateCmd.Parameters["@NewCompanyFax"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyFax", newCompany.CompanyFax);
            }

            // Company Website
            if (newCompany.CompanyWebsite == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyWebsite", DBNull.Value);
                updateCmd.Parameters["@NewCompanyWebsite"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyWebsite", newCompany.CompanyWebsite);
            }

            // Company Notes
            if (newCompany.CompanyNotes == "")
                updateCmd.Parameters.AddWithValue("@NewCompanyNotes", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewCompanyNotes", newCompany.CompanyNotes);
            // Old Company changes
            updateCmd.Parameters.AddWithValue("@OldCompanyName", oldCompany.CompanyName);
            updateCmd.Parameters.AddWithValue("@OldCompanyAddress", oldCompany.CompanyAddress);
            updateCmd.Parameters.AddWithValue("@OldCompanyCity", oldCompany.CompanyCity);
            updateCmd.Parameters.AddWithValue("@OldCompanyState", oldCompany.CompanyState);
            updateCmd.Parameters.AddWithValue("@OldCompanyZipCode", oldCompany.CompanyZipCode);
            updateCmd.Parameters.AddWithValue("@OldCompanyPhone", oldCompany.CompanyPhone);
            if (oldCompany.CompanyFax == "")
                updateCmd.Parameters.AddWithValue("@OldCompanyFax", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldCompanyFax", oldCompany.CompanyFax);
            if (oldCompany.CompanyWebsite == "")
                updateCmd.Parameters.AddWithValue("@OldCompanyWebsite", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldCompanyWebsite", oldCompany.CompanyWebsite);
            if (oldCompany.CompanyNotes == "")
                updateCmd.Parameters.AddWithValue("@OldCompanyNotes", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@OldCompanyNotes", oldCompany.CompanyNotes);

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
            finally
            {
                conn.Close();
            }
        }

        // This is the method to add a contact
        public static int AddCompany (Company newCompany)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string insertStmt =
                "INSERT Company " +
                "(com_name, com_address, com_city, com_state, com_zip_code, " +
                "com_phone, com_fax, com_website, com_notes) " +
                "VALUES (@com_name, @com_address, @com_city, @com_state, @com_zip_code, " +
                "@com_phone, @com_fax, @com_website, @com_notes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);
            insertCmd.Parameters.AddWithValue("@com_name", newCompany.CompanyName);
            insertCmd.Parameters.AddWithValue("@com_address", newCompany.CompanyAddress);
            insertCmd.Parameters.AddWithValue("@com_city", newCompany.CompanyCity);
            insertCmd.Parameters.AddWithValue("@com_state", newCompany.CompanyState);
            insertCmd.Parameters.AddWithValue("@com_zip_code", newCompany.CompanyZipCode);
            insertCmd.Parameters.AddWithValue("@com_phone", newCompany.CompanyPhone);
            if (newCompany.CompanyFax == "")
                insertCmd.Parameters.AddWithValue("@com_fax", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@com_fax", newCompany.CompanyFax);
            if (newCompany.CompanyWebsite == "")
                insertCmd.Parameters.AddWithValue("@com_website", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@com_website", newCompany.CompanyWebsite);
            if (newCompany.CompanyNotes == "")
                insertCmd.Parameters.AddWithValue("@com_notes", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@com_notes", newCompany.CompanyNotes);

            try
            {
                conn.Open();
                insertCmd.ExecuteNonQuery();
                string selectStmt =
                    "SELECT SCOPE_IDENTITY ('Company') FROM Company";
                SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
                int companyID = Convert.ToInt32(selectCmd.ExecuteScalar());
                return companyID;
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