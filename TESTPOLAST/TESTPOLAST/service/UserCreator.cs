using TESTPOLAST.model;
using TESTPOLAST.resorces;
namespace TESTPOLAST.service
{
    public class UserCreator
    {
        public static string Username = UserFirst.Username;
        public static string Password = UserFirst.Password;
        public static User user = new User(Username, Password);
    }
}
