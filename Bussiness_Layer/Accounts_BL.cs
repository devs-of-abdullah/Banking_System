using DataAccessLayer;
using System.Data;


namespace BussinessLayer
{
    public class Accounts_BL
    {
        public int AccountId { get; set; }

        public string pin { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string hashedpassword { get; set; }
        public decimal balance { get; set; }
        public DateTime createdat { get; set; }
        public bool isDeleted { get; set; }

        public Accounts_BL(int accountid, string fullname, string pin, string email, string hashedpassword, decimal balance, DateTime createdat, bool isdeleted)
        {
            this.AccountId = accountid;
            this.fullname = fullname;
            this.pin = pin;
            this.email = email;
            this.hashedpassword = hashedpassword;
            this.balance = balance;
            this.createdat = createdat;
            this.isDeleted = isdeleted;
        }

        public static int AddNewAccount(string fullname,string pin, string email, string password)
        {   string hashedPin = clsUtil.ComputeHash(pin);
            string hashedPassword = clsUtil.ComputeHash(password);
            return Accounts_DAL.AddNewAccount(fullname,hashedPin, email.ToLower(), hashedPassword);
        }
        public static bool ChangeFullname(int accountid, string fullname) => Accounts_DAL.ChangeFullname(accountid, fullname);
        public static bool ChangeEmail(int accountid, string email) => Accounts_BL.ChangeEmail(accountid, email.ToLower());
        
        public static bool DeleteAccount(int accountid) => Accounts_DAL.DeleteAccount(accountid);
        public static bool RetriveAccount(int accountid) => Accounts_DAL.RetriveAccount(accountid);
        public static bool IsAccountDeleted(int accountid) => Accounts_DAL.IsAccountDeleted(accountid);
        public static bool IsAccountExists(int accountid) => Accounts_DAL.IsAccountExists(accountid);
        public static Accounts_BL? GetAccountInfo(int accountid)
        {
            string fullname = "", pin ="", email = "", hashedpassword = ""; decimal balance = 0; DateTime createdat = DateTime.MinValue; bool isdeleted = false;

            if (!IsAccountExists(accountid)) return null;
            bool IsFound = Accounts_DAL.GetAccountInfo(accountid, ref fullname,ref pin ,ref email, ref hashedpassword, ref balance, ref createdat, ref isdeleted);
            if (!IsFound) return null;
            return new Accounts_BL(accountid, fullname,pin ,email.ToLower(), hashedpassword, balance, createdat, isdeleted);

        }
       
        public static int GetAccountIDByEmail(string email)
        {
            return Accounts_DAL.GetIDByEmail(email.ToLower());    
        }
        public static string? GetAccountEmailByID(int ID)
        {
            return Accounts_DAL.GetEmailByID(ID);
        }
        public static DataTable GetAllAccounts(byte opt) => Accounts_DAL.GetAllAccounts(opt);
        public static int Login(string email, string password)
        {
            string HashedPassword = clsUtil.ComputeHash(password);
            return Accounts_DAL.Login(email.ToLower(), HashedPassword);
        }
        public static int Login(int accountid, string password)
        {
            string hashedPassword = clsUtil.ComputeHash(password);
            return Accounts_DAL.Login(accountid, hashedPassword);
        }
        public static bool ChangePassword(int accountid, string oldpassword, string newpassword)
        {
            string HashedOldPassword = clsUtil.ComputeHash(oldpassword), HashedNewPassword = clsUtil.ComputeHash(newpassword);
            return Accounts_DAL.ChangePassword(accountid, HashedOldPassword, HashedNewPassword);
        }
        public static bool ChangePin(int accountid, string oldpin, string newpin)
        {
            string HashedOldPin = clsUtil.ComputeHash(oldpin), HashedNewPin = clsUtil.ComputeHash(newpin);
            return Accounts_DAL.ChangePin(accountid, HashedOldPin, HashedNewPin);
        }
       public static bool AtmLogin(int id, string pin)
        {
            string hashedPin = clsUtil.ComputeHash(pin);
            int CurrentUser = Accounts_DAL.LoginByPin(id, hashedPin);

            return CurrentUser != -1;
        }
         public static bool isEmailExists(string email) => Accounts_DAL.isEmailExists(email.ToLower());
    }
}