namespace Patterns.Mediator
{
    public class ChatUser : User
    {
        public ChatUser(ChatInterface room,string id, string  name):base(room, id, name)
        {
            //this.name = name; ???
        }
        public override void send(string msg, string userID)
        {
            Console.WriteLine(this.getName() + "Sending message:" + msg);
            getMediatou().sendMessage(msg, userID);
        }

        public override void receive(string msg)
        {
            Console.WriteLine(this.getName() + "Received message:" + msg);
        }
    }
}