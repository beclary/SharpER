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
        // This will provide a listing of all companies in the database
        // This returns a listing of all the companies using a List T
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
                readur.Close();
                conn.Close();
            }
            return companyList;
        }

        // This will provide the Company information given a specific companyID
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

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
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

                readur.Read();
                    if (readur[comCompanyIDOrd] == DBNull.Value)
                        specificCompany = null;
                    else
                        specificCompany.CompanyID = readur.GetInt32(comCompanyIDOrd);
                    if (readur[comCompanyNameOrd] == DBNull.Value)
                        specificCompany.CompanyName = null;
                    else
                        specificCompany.CompanyName = readur.GetString(comCompanyNameOrd);
                    if (readur[comCompanyAddressOrd] == DBNull.Value)
                        specificCompany.CompanyAddress = null;
                    else
                        specificCompany.CompanyAddress = readur.GetString(comCompanyAddressOrd);
                    if (readur[comCompanyCityOrd] == DBNull.Value)
                        specificCompany.CompanyCity = null;
                    else
                        specificCompany.CompanyCity = readur.GetString(comCompanyCityOrd);
                    if (readur[comCompanyStateOrd] == DBNull.Value)
                        specificCompany.CompanyState = null;
                    else
                        specificCompany.CompanyState = readur.GetString(comCompanyStateOrd);
                    if (readur[comCompanyZipCodeOrd] == DBNull.Value)
                        specificCompany.CompanyZipCode = null;
                    else
                        specificCompany.CompanyZipCode = readur.GetString(comCompanyZipCodeOrd);
                    if (readur[comCompanyPhoneOrd] == DBNull.Value)
                        specificCompany.CompanyPhone = null;
                    else
                        specificCompany.CompanyPhone = readur.GetString(comCompanyPhoneOrd);
                    if (readur[comCompanyFaxOrd] == DBNull.Value)
                        specificCompany.CompanyFax = null;
                    else
                        specificCompany.CompanyFax = readur.GetString(comCompanyFaxOrd);
                    if (readur[comCompanyWebsiteOrd] == DBNull.Value)
                        specificCompany.CompanyWebsite = null;
                    else
                        specificCompany.CompanyWebsite = readur.GetString(comCompanyWebsiteOrd);
                    if (readur[comCompanyNotesOrd] == DBNull.Value)
                        specificCompany.CompanyNotes = null;
                    else
                        specificCompany.CompanyNotes = readur.GetString(comCompanyNotesOrd);
                readur.Close();
                return specificCompany;
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

        // This is the method to update / modify a Company
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
                "AND (com_name = @OldCompanyName " +
                    "OR com_name IS NULL AND @OldCompanyName IS NULL)" +
                "AND (com_address = @OldCompanyAddress " +
                    "OR com_address IS NULL AND @OldCompanyAddress IS NULL)" +
                "AND (com_city = @OldCompanyCity " +
                    "OR com_city IS NULL AND @OldCompanyCity IS NULL)" +
                "AND (com_state = @OldCompanyState " +
                    "OR com_state IS NULL AND @OldCompanyState IS NULL)" +
                "AND (com_zip_code = @OldCompanyZipCode " +
                    "OR com_zip_code IS NULL AND @OldCompanyZipCode IS NULL)" +
                "AND (com_phone = @OldCompanyPhone " +
                    "OR com_phone IS NULL AND @OldCompanyPhone IS NULL)" +
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
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyNotes", DBNull.Value);
                updateCmd.Parameters["@NewCompanyNotes"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyNotes", newCompany.CompanyNotes);
            }


            // Old Company changes
            // Company Identification Number
            updateCmd.Parameters.AddWithValue("@OldCompanyID", oldCompany.CompanyID);

            // Company Name
            if (oldCompany.CompanyName == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyName", DBNull.Value);
                updateCmd.Parameters["@NewCompanyName"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyName", oldCompany.CompanyName);
            }

            // Company Address
            if (oldCompany.CompanyAddress == "")
            {
                updateCmd.Parameters.AddWithValue("@NewCompanyAddress", DBNull.Value);
                updateCmd.Parameters["@NewCompanyAddress"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyAddress", oldCompany.CompanyAddress);
            }

            // Company City
            if (oldCompany.CompanyCity == "")
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyCity", DBNull.Value);
                updateCmd.Parameters["@OldCompanyCity"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyCity", oldCompany.CompanyCity);
            }

            // Company State
            if (oldCompany.CompanyState == "")
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyState", DBNull.Value);
                updateCmd.Parameters["@OldCompanyState"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyState", oldCompany.CompanyState);
            }

            // Company ZipCode
            if (oldCompany.CompanyZipCode == "")
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyZipCode", DBNull.Value);
                updateCmd.Parameters["OldCompanyZipCode"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyZipCode", oldCompany.CompanyZipCode);
            }

            // Company Phone
            if (oldCompany.CompanyPhone == "")
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyPhone", DBNull.Value);
                updateCmd.Parameters["@OldCompanyPhone"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyPhone", oldCompany.CompanyPhone);
            }

            // Company Fax
            if (oldCompany.CompanyFax == "")
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyFax", DBNull.Value);
                updateCmd.Parameters["@OldCompanyFax"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyFax", oldCompany.CompanyFax);
            }

            // Company Website
            if (oldCompany.CompanyWebsite == "")
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyWebsite", DBNull.Value);
                updateCmd.Parameters["@OldCompanyWebsite"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyWebsite", oldCompany.CompanyWebsite);
            }

            // Company Notes
            if (oldCompany.CompanyNotes == "")
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyNotes", DBNull.Value);
                updateCmd.Parameters["OldCompanyNotes"].IsNullable = true;
            }
            else
            {
                updateCmd.Parameters.AddWithValue("@OldCompanyNotes", oldCompany.CompanyNotes);
            }


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
        public static int AddCompany (Company newCompany)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string insertStmt =
                "INSERT INTO Company " +
                "(com_name, com_address, com_city, com_state, com_zip_code, " +
                "com_phone, com_fax, com_website, com_notes) " +
                "VALUES (@CompanyName, @CompanyAddress, @CompanyCity, @CompanyState, @CompanyZipCode, " +
                "@CompanyPhone, @CompanyFax, @CompanyWebsite, @CompanyNotes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);

            // Company Name
            if (newCompany.CompanyName == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyName", DBNull.Value);
                insertCmd.Parameters["@CompanyName"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyName", newCompany.CompanyName);
            }

            // Company Address
            if (newCompany.CompanyAddress == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyAddress", DBNull.Value);
                insertCmd.Parameters["@CompanyAddress"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyAddress", newCompany.CompanyAddress);
            }

            // Company City
            if (newCompany.CompanyCity == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyCity", DBNull.Value);
                insertCmd.Parameters["@CompanyCity"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyCity", newCompany.CompanyCity);
            }

            // Company State
            if (newCompany.CompanyState == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyState", DBNull.Value);
                insertCmd.Parameters["@CompanyState"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyState", newCompany.CompanyState);
            }

            // Company ZipCode
            if (newCompany.CompanyZipCode == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyZipCode", DBNull.Value);
                insertCmd.Parameters["@CompanyZipCode"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyZipCode", newCompany.CompanyZipCode);
            }

            // Company Phone
            if (newCompany.CompanyPhone == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyPhone", DBNull.Value);
                insertCmd.Parameters["@CompanyPhone"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyPhone", newCompany.CompanyPhone);
            }

            // Company Fax
            if (newCompany.CompanyFax == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyFax", DBNull.Value);
                insertCmd.Parameters["@CompanyFax"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyFax", newCompany.CompanyFax);
            }

            // Company Website
            if (newCompany.CompanyWebsite == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyWebsite", DBNull.Value);
                insertCmd.Parameters["@CompanyWebsite"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyWebsite", newCompany.CompanyWebsite);
            }

            // Company Notes
            if (newCompany.CompanyNotes == null)
            {
                insertCmd.Parameters.AddWithValue("@CompanyNotes", DBNull.Value);
                insertCmd.Parameters["@CompanyNotes"].IsNullable = true;
            }
            else
            {
                insertCmd.Parameters.AddWithValue("@CompanyNotes", newCompany.CompanyNotes);
            }

            try
            {
                conn.Open();
                insertCmd.ExecuteNonQuery();
                string selectStmt =
                    "SELECT IDENT_CURRENT ('Company') FROM Company";
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

        // This is the method to delete a company
        public static int DeleteCompany(int companyID)
        {
            SqlConnection conn = SharpERDB.GetConnection();
            string selectStmt =
                "DELETE FROM Company " +
                "WHERE com_ID = @CompanyID";
            SqlCommand deleteCmd = new SqlCommand(selectStmt, conn);
            deleteCmd.Parameters.AddWithValue("@CompanyID", companyID);

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