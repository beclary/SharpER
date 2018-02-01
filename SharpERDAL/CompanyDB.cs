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
            throw new System.NotImplementedException();
        }
    }
}