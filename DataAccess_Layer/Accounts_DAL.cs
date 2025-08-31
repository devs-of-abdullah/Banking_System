using DataAccess_Layer;
using Npgsql;
using System.Data;


namespace DataAccessLayer
{

    public class Accounts_DAL
    {

        public static string ConnectionString = clsDataAccessSettings.ConnectionString;

        static public int AddNewAccount(string fullname, string pin, string email, string passwordhash)
        {
        

            const string query = @"
                INSERT INTO accounts (fullname,pin ,email, passwordhash )
                VALUES (@fullname,@pin, @email, @passwordhash)
                RETURNING accountid;
            ";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@fullname", fullname);
                command.Parameters.AddWithValue("@pin", pin);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@passwordhash", passwordhash);

                connection.Open();
                var result = command.ExecuteScalar();

                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (PostgresException pgEx)
            {
                if (pgEx.SqlState == "23505")
                    Console.Error.WriteLine("Email already exists.");
                else
                    Console.Error.WriteLine($"Postgres Error {pgEx.SqlState}: {pgEx.Message}");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return -1;
        }

        static public bool ChangeFullname(int AccountID, string Newfullname)
        {


            const string query = @"
                UPDATE accounts 
                SET fullname = @fullname
                WHERE accountid = @accountid;
            ";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@accountid", AccountID);
                command.Parameters.AddWithValue("@fullname", Newfullname);
               

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }
        static public bool ChangeEmail(int AccountID, string NewEmail)
        {


            const string query = @"
                UPDATE accounts 
                SET email = @email
                WHERE accountid = @accountid;
            ";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@accountid", AccountID);
                command.Parameters.AddWithValue("@fullname", NewEmail);


                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }
        static public bool DeleteAccount(int AccountID)
        {
      

            const string query = "UPDATE accounts SET isdeleted = TRUE WHERE accountid = @accountid;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@accountid", AccountID);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }

        static public bool RetriveAccount(int AccountID)
        {
            

            const string query = "UPDATE accounts SET isdeleted = FALSE WHERE accountid = @accountid;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@accountid", AccountID);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }

        static public bool IsAccountDeleted(int AccountID)
        {
          

            const string query = "SELECT isdeleted FROM accounts WHERE accountid = @accountid;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@accountid", AccountID);

                connection.Open();
                var result = command.ExecuteScalar();
                return result != null && Convert.ToBoolean(result);
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }

        static public bool IsAccountExists(int AccountID)
        {
          

            const string query = "SELECT 1 FROM accounts WHERE accountid = @accountid;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@accountid", AccountID);

                connection.Open();
                var result = command.ExecuteScalar();
                return result != null;
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }

        static public bool GetAccountInfo(int AccountID, ref string fullname, ref string pin, ref string email, ref string passwordhash, ref decimal balance, ref DateTime createdat, ref bool isdeleted)
        {
  

            const string query = @"
                SELECT fullname,pin, email, passwordhash, balance, createdat, isdeleted
                FROM accounts 
                WHERE accountid = @accountid;
            ";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@accountid", AccountID);

                connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    fullname = reader.GetString(reader.GetOrdinal("fullname"));
                    pin = reader.GetString(reader.GetOrdinal("pin"));
                    email = reader.GetString(reader.GetOrdinal("email"));
                    passwordhash = reader.GetString(reader.GetOrdinal("passwordhash"));
                    balance = reader.GetDecimal(reader.GetOrdinal("balance"));
                    createdat = reader.GetDateTime(reader.GetOrdinal("createdat"));
                    isdeleted = reader.GetBoolean(reader.GetOrdinal("isdeleted"));

                    return true;
                }
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }
        static public int GetIDByEmail(string email)
        {
            int ID;

            const string query = @"
                SELECT accountid
                FROM accounts 
                WHERE email = @email;
            ";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);

                connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = reader.GetInt32(reader.GetOrdinal("accountid"));
                  

                    return ID;
                }
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return -1;
        }
        static public string? GetEmailByID(int ID)
        {
            string Email;

            const string query = @"
                SELECT email
                FROM accounts 
                WHERE accountid = @accountid;
            ";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@accountid", ID);

                connection.Open();
                using var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Email = reader.GetString(reader.GetOrdinal("email"));


                    return Email;
                }
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return null;
        }
        static public DataTable GetAllAccounts(byte opt)
        {
          

            DataTable dtAllAccounts = new DataTable();
            string query = opt switch
            {
                0 => "SELECT * FROM accounts;",
                1 => "SELECT * FROM accounts WHERE isdeleted = FALSE;",
                2 => "SELECT * FROM accounts WHERE isdeleted = TRUE;",
                _ => throw new ArgumentException("Invalid option")
            };

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                connection.Open();
                using var reader = command.ExecuteReader();
                dtAllAccounts.Load(reader);
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return dtAllAccounts;
        }

        static public int Login(string email, string password)
        {
         

            const string query = @"SELECT accountid FROM accounts
                WHERE email = @email AND passwordhash = @password;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                using var reader = command.ExecuteReader();


                if (reader.Read())
                {
                    int CurrentID = reader.GetInt32(reader.GetOrdinal("accountid"));
                    Sessions_DAL.AccountLogedToSystem(CurrentID);
                    return CurrentID;
                }


            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
            return -1;
        }

        static public int Login(int accountid, string password)
        {
           

            const string query = "SELECT accountid FROM accounts WHERE accountid = @accountid AND passwordhash = @password;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@accountid", accountid);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {

                    int CurrentID = reader.GetInt32(reader.GetOrdinal("accountid"));
                    Sessions_DAL.AccountLogedToSystem(CurrentID);
                    return CurrentID;
                }



            }
            catch (PostgresException pgEx)
            {
                Console.Error.WriteLine(pgEx.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);

            }
            return -1;
        }

        static public bool ChangePassword(int accountid, string OldPassword, string NewPassword)
        {
            

            const string query = @"
                UPDATE accounts 
                SET passwordhash = @newpassword
                WHERE accountid = @accountid AND passwordhash = @oldpassword;
            ";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@newpassword", NewPassword);
                command.Parameters.AddWithValue("@accountid", accountid);
                command.Parameters.AddWithValue("@oldpassword", OldPassword);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }
        static public bool ChangePin(int accountid, string OldPin, string NewPin)
        {


            const string query = @"
                UPDATE accounts 
                SET pin = @newpin
                WHERE accountid = @accountid AND pin = @oldpin;
            ";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@newpin", NewPin);
                command.Parameters.AddWithValue("@accountid", accountid);
                command.Parameters.AddWithValue("@oldpin", OldPin);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }

            return false;
        }
        static public decimal GetAccountBalance(int accountid)
        {

          

            const string query = "SELECT balance FROM accounts WHERE accountid = @accountid AND isdeleted = FALSE";
            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@accountid", accountid);


                connection.Open();

                var balance = command.ExecuteScalar() as decimal?;
                return balance ?? 0m;

            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
            return 0m;

        }
        static public int LoginByPin(int id, string pin)
        {


            const string query = @"SELECT accountid FROM accounts
                WHERE accountid = @accountid AND pin = @pin;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);

                command.Parameters.AddWithValue("@accountid",id);
                command.Parameters.AddWithValue("@pin", pin);

                connection.Open();
                using var reader = command.ExecuteReader();


                if (reader.Read())
                {
                    int CurrentID = reader.GetInt32(reader.GetOrdinal("accountid"));
                    Sessions_DAL.AccountLogedToSystem(CurrentID);
                    return CurrentID;
                }


            }
            catch (PostgresException pgEx) { Console.Error.WriteLine(pgEx.Message); }
            catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
            return -1;
        }
        static public bool isEmailExists(string email)
        {
            const string query = @"
        SELECT 1
        FROM accounts 
        WHERE email = @email;";

            try
            {
                using var connection = new NpgsqlConnection(ConnectionString);
                using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);

                connection.Open();

                var result = command.ExecuteScalar();
                return result != null;
            }
            catch (PostgresException pgEx)
            {
                Console.Error.WriteLine(pgEx.Message);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }

            return false;
        }



    }
}


           