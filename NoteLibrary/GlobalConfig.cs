using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLibrary
{
    public static class GlobalConfig
    {
        public static List<DB_Connection> ConnectionList { get; private set; }=new List<DB_Connection>();
        
        public static DB_Connection InitializeConnection()
        {
            string URI = "mongodb+srv://opwinopwin:t25366021@cluster0.kc41ysl.mongodb.net/?retryWrites=true&w=majority";
            DB_Connection connection = new DB_Connection(URI);
            ConnectionList.Add(connection);
            return connection;
        }

    }
}
