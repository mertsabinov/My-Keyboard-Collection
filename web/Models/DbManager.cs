using System.Collections.Generic;

namespace web.Models
{
    public class DbManager
    {
        private static List<Keyboard> _data = new List<Keyboard>();

        public static List<Keyboard> GetAllData()
        {
            return _data;
        }

        public static void AddKeyboard(Keyboard keyboard)
        {
            _data.Add(keyboard);
        }
    }
}