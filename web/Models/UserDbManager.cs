using System;
using System.Collections.Generic;
using System.Web.UI;

namespace web.Models
{
    public class UserDbManager
    {
        private static List<User> _userData = new List<User>();

        public static User UserLogin(string userName, string password)
        {
            User user = _userData.Find(u => (u.UserName.Equals(userName) && u.Password.Equals(password)));
            return user;
        }

        public static string UserRegister(string userName, string password)
        {
            if ( _userData.Find(u => u.UserName.Equals(userName)) is null)
            {
                User u = new User();
                u.Id = Guid.NewGuid().ToString();
                u.UserName = userName;
                u.Password = password; 
                _userData.Add(u);
                return "";
            }
            return "This username already exist";
        }

        public static User UserGetId(string id)
        { 
            User user = _userData.Find(u => u.Id.Equals(id));
            return user;
        }

        public static string UserGetUserName(string id)
        {
            User user = UserGetId(id);
            return user.UserName;
        }
    }
}