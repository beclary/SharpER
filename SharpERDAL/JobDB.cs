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
                    Contact comRowInfo = new Contact();
                    comRowInfo.ContactID = readur.GetInt32(conContactIDOrd);
                    comRowInfo.ContactFirstName = readur.GetString(conContactFirstNameOrd);
                    comRowInfo.ContactLastName = readur.GetString(conContactLastNameOrd);
                    comRowInfo.ContactTitle = readur.GetString(conContactTitleOrd);
                    comRowInfo.ContactDepartment = readur.GetString(conContactDepartmentOrd);
                    comRowInfo.ContactAddress = readur.GetString(conContactAddressOrd);
                    comRowInfo.ContactCity = readur.GetString(conContactCityOrd);
                    comRowInfo.ContactState = readur.GetString(conContactStateOrd);
                    comRowInfo.ContactZipCode = readur.GetString(conContactZipCodeOrd);
                    comRowInfo.ContactPhone = readur.GetString(conContactPhoneOrd);
                    comRowInfo.ContactMobile = readur.GetString(conContactMobileOrd);
                    comRowInfo.ContactFax = readur.GetString(conContactFaxOrd);
                    comRowInfo.ContactEmail = readur.GetString(conContactEmailOrd);
                    comRowInfo.ContactContactedVia = readur.GetString(conContactContactedViaOrd);
                    comRowInfo.ContactNotes = readur.GetString(conContactNotesOrd);
                    contactList.Add(comRowInfo);
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