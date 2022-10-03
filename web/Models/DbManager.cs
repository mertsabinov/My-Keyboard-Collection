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

        public static string UserRegister(string userName, string password)
        {
            if ( UserData.Find(u => u.UserName.Equals(userName)) is null)
            {
                User u = new User();
                u.Id = Guid.NewGuid().ToString();
                u.UserName = userName;
                u.Password = password;
                UserData.Add(u);
                return "";
            }
            return "This username already exist";
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