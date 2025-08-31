
using DataAccessLayer;
using System.Data;


namespace BussinessLayer
{
    public static class Transactions_BL
    {
        public static DataTable GetAllTranstactions(int AccountID, bool Sent)
         => DataAccessLayer.Transactions_DAL.GetTransactions(AccountID, Sent);

        public static bool TransferBetweenAccounts(int SenderID, int RecieverID,decimal Amount, string Description = "")
         => DataAccessLayer.Transactions_DAL.TransferBetweenAccounts(SenderID, RecieverID, Amount, Description);
        public static bool DepositIntoAccount(int AccountID, string Password, decimal Balance, string Description = "")
        {
            int? CurrentUser = Accounts_BL.Login(AccountID, Password);

            if (CurrentUser != null) return DataAccessLayer.Transactions_DAL.DepositIntoAccount(AccountID, Balance, Description);

            return false;
        }
        public static bool WithdrawFromAccount(int AccountID, string Password, decimal Balance, string Description = "")
        {
            int? CurrentUser = Accounts_BL.Login(AccountID, Password);

            if (CurrentUser != null) return DataAccessLayer.Transactions_DAL.WithdrawFromAccount(AccountID, Balance, Description);

            return false;

        }
        
        public static bool DepositByATM(int ID,decimal balance)
        {
                   return Transactions_DAL.DepositIntoAccount(ID, balance,"ATM");
     
        }
        public static bool WithdrawByATM(int ID, decimal balance)
        {
            
            
                return Transactions_DAL.WithdrawFromAccount(ID, balance, "ATM");
            
        }

        public static DataTable GetAllWithdraws(int ID) => Transactions_DAL.GetAllWithdrawsOfAccount(ID);

        public static DataTable GetAllDeposits(int ID) =>Transactions_DAL.GetAllDepositssOfAccount(ID);
        
    }
}