using System.Data;
using Microsoft.Data.SqlClient;
using AddressBook.Models;
using AddressBook.Data;

namespace AddressBook.Repository
{
    public class ContactRepository
    {
        SqlConnection conn = DbConnection.GetConnection();

        void Execute(SqlCommand cmd)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        void Show(SqlCommand cmd)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"{dr["ContactId"]} {dr["FirstName"]} {dr["City"]} {dr["State"]} {dr["Phone"]}");
            }
            
            conn.Close();
        }

        public void Add(Contact c)
        {
            SqlCommand cmd = new SqlCommand("sp_AddContact", conn);
            cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
            cmd.Parameters.AddWithValue("@LastName", c.LastName);
            cmd.Parameters.AddWithValue("@Address", c.Address);
            cmd.Parameters.AddWithValue("@City", c.City);
            cmd.Parameters.AddWithValue("@State", c.State);
            cmd.Parameters.AddWithValue("@Zip", c.Zip);
            cmd.Parameters.AddWithValue("@Phone", c.Phone);
            cmd.Parameters.AddWithValue("@Email", c.Email);
            Execute(cmd);
        }

        public void Update(Contact c)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateContact", conn);
            cmd.Parameters.AddWithValue("@ContactId", c.ContactId);
            cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
            cmd.Parameters.AddWithValue("@LastName", c.LastName);
            cmd.Parameters.AddWithValue("@City", c.City);
            Execute(cmd);
        }

        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_DeleteContact", conn);
            cmd.Parameters.AddWithValue("@ContactId", id);
            Execute(cmd);
        }

        public void ViewAll() => Show(new SqlCommand("sp_ViewAll", conn));
        public void SearchCity(string city)
        {
            SqlCommand cmd = new SqlCommand("sp_SearchCity", conn);
            cmd.Parameters.AddWithValue("@City", city);
            Show(cmd);
        }

        public void SearchState(string state)
        {
            SqlCommand cmd = new SqlCommand("sp_SearchState", conn);
            cmd.Parameters.AddWithValue("@State", state);
            Show(cmd);
        }

        public void SortName() => Show(new SqlCommand("sp_SortName", conn));
        public void SortCity() => Show(new SqlCommand("sp_SortCity", conn));
        public void SortState() => Show(new SqlCommand("sp_SortState", conn));

        public void CountCity(string city)
{
    SqlCommand cmd = new SqlCommand("sp_CountCity", conn);
    cmd.CommandType = CommandType.StoredProcedure;

    cmd.Parameters.AddWithValue("@City", city);

    conn.Open();
    int count = Convert.ToInt32(cmd.ExecuteScalar());
    Console.WriteLine("Count = " + count);
    conn.Close();
}


       public void CountState(string state)
{
    SqlCommand cmd = new SqlCommand("sp_CountState", conn);
    cmd.CommandType = CommandType.StoredProcedure;

    cmd.Parameters.AddWithValue("@State", state);

    conn.Open();
    int count = Convert.ToInt32(cmd.ExecuteScalar());
    Console.WriteLine("Count = " + count);
    conn.Close();
}

    }
}
