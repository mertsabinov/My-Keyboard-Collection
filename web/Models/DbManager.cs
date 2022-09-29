using System.Collections.Generic;

namespace web.Models
{
    public class DbManager

    {
    public List<Keyboard> Data;

    public void Add(Keyboard keyboard)
    {
        Data.Add(keyboard);
    }

    public Data GetAllKeyboard(string id)
    {
        return Data;
    }
    }
}