using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMsg(User user,string msg)
        {
            Console.WriteLine("["+user.Name+"]:"+msg);
        }
    }
}
