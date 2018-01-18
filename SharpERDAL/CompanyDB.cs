using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;

namespace SharpERDAL
{
    public class CompanyDB
    {
        /// <summary>
        /// This will provide a listing of all companies in the database
        /// </summary>
        public static List<Company> GetAllCompanies()
        {
            throw new System.NotImplementedException();
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