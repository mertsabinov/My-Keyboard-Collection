using System;
using System.Collections.Generic;
using System.Web.UI;

namespace web.Models
{
    public class DbManager
    {
        public static List<Keyboard> Data = new List<Keyboard>();
        public static List<User> UserData = new List<User>();

        public static User UserLogin(string userName, string password)
        {
            User user = UserData.Find(u => (u.UserName.Equals(userName) && u.Password.Equals(password)));
            return user;
        }

        public static void UserRegister(string userName, string password)
        {
            User u = new User();
            u.Id = Guid.NewGuid().ToString();
            u.UserName = userName;
            u.Password = password;
            UserData.Add(u);
        }

        public static User UserGetId(string id)
        { 
            User user = UserData.Find(u => u.Id.Equals(id));
            return user;
        }

        public static string UserGetUserName(string id)
        {
            User user = UserGetId(id);
            return user.UserName;
        }
    }
}