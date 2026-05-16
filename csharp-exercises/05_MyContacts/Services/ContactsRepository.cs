using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_exercises._05_MyContacts.Repository;
using System.Data.SqlClient;


namespace csharp_exercises._05_MyContacts.Services
{
    class ContactsRepository : IContactsRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true";
        public bool Delete(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            string query = "select * from MyContacts";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter =  new SqlDataAdapter(query , connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

            
        }

        public DataTable SelectRow(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool Update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}
