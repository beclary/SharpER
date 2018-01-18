using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SharpERBLL;
using SharpERDAL;


namespace SharpERDAL
{
    public class ContactDB
    {
        /// <summary>
        /// This will provide a listing of all the customers in the database
        /// </summary>
        /// <returns>a listing of all the customers using a list tee</returns>
        public static List<Contact> GetAllContacts()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// This will provide the Contact information given a specific contactID
        /// </summary>
        public static Contact GetSpecificContactInfo(int contactID)
        {
            throw new System.NotImplementedException();
        }
    }
}