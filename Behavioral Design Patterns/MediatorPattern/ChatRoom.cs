using System;

namespace MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMsg(User user, string msg)
        {
            Console.WriteLine("[" + user.Name + "]:" + msg);
        }
    }
}