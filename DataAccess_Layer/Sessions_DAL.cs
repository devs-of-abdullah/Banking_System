using DataAccess_Layer;
using Npgsql;



namespace DataAccessLayer
{
    public class Sessions_DAL
    {
        public static string ConnectionString = clsDataAccessSettings.ConnectionString;
        static public int AccountLogedToSystem(int accountid)
        {
          

            const string query = "insert into sessions(accountid) values(@accountid) returning accountid;";


            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@accountid", accountid);
                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());

            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return -1;
        }
    }
}