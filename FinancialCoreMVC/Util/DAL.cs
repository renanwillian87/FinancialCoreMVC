using System.Data;
using System.Data.SqlClient;

namespace FinancialCoreMVC.Util
{
    public class DAL
    {
        private static string server = "local";
        private static string database = "FinancialCoreMVC";
        private static string user = "FinancialCoreMVC";
        private static string password = "!123asw";
        private string connectionString = $"Data Source=({server});Initial Catalog={database};User Id={user};Password={password};Integrated Security=SSPI;";
        private SqlConnection  connection;

        public DAL()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        
        // Executa SELECT
        public DataTable RetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dataTable);
            return dataTable;
        }

        // Execute INSERTs, UPDATEs, DELETEs
        public void ExecutarComandoSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
