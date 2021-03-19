namespace MediatorPattern
{
    public class User
    {
        public string Name { get; internal set; }

        public User(string name)
        {
            Name = name;
        }

        public void SendMsg(string msg)
        {
            ChatRoom.ShowMsg(this,msg);
        }
    }
}