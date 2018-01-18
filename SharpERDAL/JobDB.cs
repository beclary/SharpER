using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;

namespace SharpERDAL
{
    public static class JobDB
    {
        /// <summary>
        /// This will provide a listing of all Jobs that are available in the database
        /// </summary>
        public static List<Job> GetAllJobs()
        {
            List<Job> contactList = new List<Job>();
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
                int conContactLastNameOrd = readur.GetOrdinal("CoontactLastName");
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
                    Contact actRowInfo = new Contact();
                    actRowInfo.ContactID = readur.GetInt32(conContactIDOrd);
                    actRowInfo.ContactFirstName = readur.GetString(conContactFirstNameOrd);
                    actRowInfo.ContactLastName = readur.GetString(conContactLastNameOrd);
                    actRowInfo.ContactTitle = readur.GetString(conContactTitleOrd);
                    actRowInfo.ContactDepartment = readur.GetString(conContactDepartmentOrd);
                    actRowInfo.ContactAddress = readur.GetString(conContactAddressOrd);
                    actRowInfo.ContactCity = readur.GetString(conContactCityOrd);
                    actRowInfo.ContactState = readur.GetString(conContactStateOrd);
                    actRowInfo.ContactZipCode = readur.GetString(conContactZipCodeOrd);
                    actRowInfo.ContactPhone = readur.GetString(conContactPhoneOrd);
                    actRowInfo.ContactMobile = readur.GetString(conContactMobileOrd);
                    actRowInfo.ContactFax = readur.GetString(conContactFaxOrd);
                    actRowInfo.ContactEmail = readur.GetString(conContactEmailOrd);
                    comRowInfo.ContactContactedVia = readur.GetString(conContactContactedViaOrd);
                    comRowInfo.ContactNotes = readur.GetString(conContactNotesOrd);
                    contactList.Add(actRowInfo);
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
        /// This will provide the job information given a specific jobID
        /// </summary>
        public static Job GetSpecificJobInfo(int jobID)
        {
            throw new System.NotImplementedException();
        }
    }
}