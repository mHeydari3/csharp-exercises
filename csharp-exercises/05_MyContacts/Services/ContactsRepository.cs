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
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From MyContacts Where ContactID=@ID";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@ID" , contactId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;


            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string name, string family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                string query = "Insert Into MyContacts(Name,Family,Email,Age,Mobile,Address) values (@Name, @Family, @Email, @Age , @Mobile , @Address)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);

                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.Parameters.AddWithValue("@Family" , family);
                sqlCommand.Parameters.AddWithValue("@Mobile", mobile);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@Age", age);
                sqlCommand.Parameters.AddWithValue("@Address", address);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
                connection.Close();





                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Search(string parameter)
        {
            string query = "select * from MyContacts WHERE Name like @parameter or Family like @parameter   ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");


            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
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
            string query = "select * from MyContacts Where ContactId = "+contactId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                //string query = "Insert Into MyContacts(Name,Family,Email,Age,Mobile,Address) values (@Name, @Family, @Email, @Age , @Mobile , @Address)";
                string query_update = "UPDATE MyContacts SET Name = @Name ,Family = @Family , Mobile = @Mobile , Email = @Email , Age = @Age , Address = @Address " +
                    "WHERE ContactID = @ContactId";

               
                SqlCommand sqlCommand = new SqlCommand(query_update, connection);

                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.Parameters.AddWithValue("@Family", family);
                sqlCommand.Parameters.AddWithValue("@Mobile", mobile);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@Age", age);
                sqlCommand.Parameters.AddWithValue("@Address", address);
                sqlCommand.Parameters.AddWithValue("@ContactId", contactId);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
                

                
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
