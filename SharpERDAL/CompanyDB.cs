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
                "ORDER BY CompanyID";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int comCompanyIDOrd = readur.GetOrdinal("CompanyID");
                int comCompanyNameOrd = readur.GetOrdinal("CompanyName");
                int comCompanyAddressOrd = readur.GetOrdinal("CompanyAddress");
                int comCompanyCityOrd = readur.GetOrdinal("CompanyCity");
                int comCompanyStateOrd = readur.GetOrdinal("CompanyState");
                int comCompanyZipCodeOrd = readur.GetOrdinal("CompanyZipCode");
                int comCompanyPhoneOrd = readur.GetOrdinal("CompanyPhone");
                int comCompanyFaxOrd = readur.GetOrdinal("CompanyFax");
                int comCompanyWebsiteOrd = readur.GetOrdinal("CompanyWebsite");
                int comCompanyNotesOrd = readur.GetOrdinal("CompanyNotes");

                while (readur.Read())
                {
                    Company comRowInfo = new Company();
                    comRowInfo.CompanyID = readur.GetInt32(comCompanyIDOrd);
                    comRowInfo.CompanyName = readur.GetString(comCompanyNameOrd);
                    comRowInfo.CompanyAddress = readur.GetString(comCompanyAddressOrd);
                    comRowInfo.CompanyCity = readur.GetString(comCompanyCityOrd);
                    comRowInfo.CompanyState = readur.GetString(comCompanyStateOrd);
                    comRowInfo.CompanyZipCode = readur.GetString(comCompanyZipCodeOrd);
                    comRowInfo.CompanyPhone = readur.GetString(comCompanyPhoneOrd);
                    comRowInfo.CompanyFax = readur.GetString(comCompanyFaxOrd);
                    comRowInfo.CompanyWebsite = readur.GetString(comCompanyWebsiteOrd);
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
                "SELECT CompanyID, CompanyName, CompanyAddress, CompanyCity, " +
                "CompanyState, CompanyZipCode, CompanyPhone, CompanyFax, " +
                "CompanyWebsite, CompanyNotes " +
                "FROM Company " +
                "WHERE CompanyID = @CompanyID";
            SqlCommand selectCmd = new SqlCommand(selectStmt, conn);
            selectCmd.Parameters.AddWithValue("@CompanyID", companyID);

            try
            {
                conn.Open();
                SqlDataReader readur = selectCmd.ExecuteReader();
                int comCompanyIDOrd = readur.GetOrdinal("CompanyID");
                int comCompanyNameOrd = readur.GetOrdinal("CompanyName");
                int comCompanyAddressOrd = readur.GetOrdinal("CompanyAddress");
                int comCompanyCityOrd = readur.GetOrdinal("CompanyCity");
                int comCompanyStateOrd = readur.GetOrdinal("CompanyState");
                int comCompanyZipCodeOrd = readur.GetOrdinal("CompanyZipCode");
                int comCompanyPhoneOrd = readur.GetOrdinal("CompanyPhone");
                int comCompanyFaxOrd = readur.GetOrdinal("CompanyFax");
                int comCompanyWebsiteOrd = readur.GetOrdinal("CompanyWebsite");
                int comCompanyNotesOrd = readur.GetOrdinal("CompanyNotes");

                while (readur.Read())
                {
                    Company specificCompanyRowInfo = new Company();
                    specificCompanyRowInfo.CompanyID = readur.GetInt32(comCompanyIDOrd);
                    specificCompanyRowInfo.CompanyName = readur.GetString(comCompanyNameOrd);
                    specificCompanyRowInfo.CompanyAddress = readur.GetString(comCompanyAddressOrd);
                    specificCompanyRowInfo.CompanyCity = readur.GetString(comCompanyCityOrd);
                    specificCompanyRowInfo.CompanyState = readur.GetString(comCompanyStateOrd);
                    specificCompanyRowInfo.CompanyZipCode = readur.GetString(comCompanyZipCodeOrd);
                    specificCompanyRowInfo.CompanyPhone = readur.GetString(comCompanyPhoneOrd);
                    specificCompanyRowInfo.CompanyFax = readur.GetString(comCompanyFaxOrd);
                    specificCompanyRowInfo.CompanyWebsite = readur.GetString(comCompanyWebsiteOrd);
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
                "CompanyName = @NewCompanyName, " +
                "CompanyAddress = @NewCompanyAddress, " +
                "CompanyCity = @NewCompanyCity, " +
                "CompanyState = @NewCompanyState, " +
                "CompanyZipCode = @NewCompanyZipCode, " +
                "CompanyPhone = @NewCompanyPhone, " +
                "CompanyFax = @NewCompanyFax, " +
                "CompanyWebsite = @NewCompanyWebsite, " +
                "CompanyNotes = @NewCompanyNotes " +
                "WHERE CompanyID = @OldCompanyID " +
                "AND CompanyName = @OldCompanyName " +
                "AND CompanyAddress = @OldCompanyAddress " +
                "AND CompanyCity = @OldCompanyCity " +
                "AND CompanyState = @OldCompanyState " +
                "AND CompanyZipCode = @OldCompanyZipCode " +
                "AND CompanyPhone = @OldCompanyPhone " +
                "AND (CompanyFax = @OldCompanyFax " +
                    "OR CompanyFax IS NULL AND @OldCompanyFax IS NULL) " +
                "AND (CompanyWebsite = @OldCompanyWebsite " +
                    "OR CompanyWebsite IS NULL AND @OldCompanyWebsite IS NULL) " +
                "AND CompanyNotes = @OldCompanyNotes " +
                    "OR CompanyNotes IS NULL AND @OldCompanyNotes IS NULL)";
            SqlCommand updateCmd = new SqlCommand(updateStmt, conn);
            // New Company changes
            updateCmd.Parameters.AddWithValue("@NewCompanyName", newCompany.CompanyName);
            updateCmd.Parameters.AddWithValue("@NewCompanyAddress", newCompany.CompanyAddress);
            updateCmd.Parameters.AddWithValue("@NewCompanyCity", newCompany.CompanyCity);
            updateCmd.Parameters.AddWithValue("@NewCompanyState", newCompany.CompanyState);
            updateCmd.Parameters.AddWithValue("@NewCompanyZipCode", newCompany.CompanyZipCode);
            updateCmd.Parameters.AddWithValue("@NewCompanyPhone", newCompany.CompanyPhone);
            if (newCompany.CompanyFax == "")
                updateCmd.Parameters.AddWithValue("@NewCompanyFax", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewCompanyFax", newCompany.CompanyFax);
            if (newCompany.CompanyWebsite == "")
                updateCmd.Parameters.AddWithValue("@NewCompanyWebsite", DBNull.Value);
            else
                updateCmd.Parameters.AddWithValue("@NewCompanyWebsite", newCompany.CompanyWebsite);
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
                "(CompanyName, CompanyAddress, CompanyCity, CompanyState, CompanyZipCode, " +
                "CompanyPhone, CompanyFax, CompanyWebsite, CompanyNotes) " +
                "VALUES (@CompanyName, @CompanyAddress, @CompanyCity, @CompanyState, " +
                "@CompanyZipCode, @CompanyPhone, @CompanyFax, @CompanyWebsite, @CompanyNotes)";
            SqlCommand insertCmd = new SqlCommand(insertStmt, conn);
            insertCmd.Parameters.AddWithValue("@CompanyName", newCompany.CompanyName);
            insertCmd.Parameters.AddWithValue("@CompanyAddress", newCompany.CompanyAddress);
            insertCmd.Parameters.AddWithValue("@CompanyCity", newCompany.CompanyCity);
            insertCmd.Parameters.AddWithValue("@CompanyState", newCompany.CompanyState);
            insertCmd.Parameters.AddWithValue("@CompanyZipCode", newCompany.CompanyZipCode);
            insertCmd.Parameters.AddWithValue("@CompanyPhone", newCompany.CompanyPhone);
            if (newCompany.CompanyFax == "")
                insertCmd.Parameters.AddWithValue("@CompanyFax", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@CompanyFax", newCompany.CompanyFax);
            if (newCompany.CompanyWebsite == "")
                insertCmd.Parameters.AddWithValue("@CompanyWebsite", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@CompanyWebsite", newCompany.CompanyWebsite);
            if (newCompany.CompanyNotes == "")
                insertCmd.Parameters.AddWithValue("@CompanyNotes", DBNull.Value);
            else
                insertCmd.Parameters.AddWithValue("@CompanyNotes", newCompany.CompanyNotes);

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