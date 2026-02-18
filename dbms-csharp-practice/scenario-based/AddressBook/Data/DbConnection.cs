using Microsoft.Data.SqlClient;

namespace AddressBook.Data
{
    public class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                "Data Source=.;Initial Catalog=AddressBookDB;Integrated Security=True;TrustServerCertificate=True"
            );
        }
    }
}
