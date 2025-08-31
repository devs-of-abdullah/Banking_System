
namespace BussinessLayer
{
    public class Sessions_BL
    {
        public static int AccountLogedToSystem(int Accountid) => DataAccessLayer.Sessions_DAL.AccountLogedToSystem(Accountid);

    }
}