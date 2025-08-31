using DataAccess_Layer;
using Npgsql;


namespace DataAccessLayer
{
    public class Global_DAL
    {
       
           public static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static public decimal GetTotalBalanceAtSystem(bool Active)
        {
          

            string query = Active ? "select sum(balance) from accounts where isdeleted = false;" :
           "select sum(balance) from accounts where isdeleted = true;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                connection.Open();

                return Convert.ToDecimal(command.ExecuteScalar());
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return 0;
        }

    }
}