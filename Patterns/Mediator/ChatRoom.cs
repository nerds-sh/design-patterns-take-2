namespace Patterns.Mediator
{
    public class ChatRoom : ChatInterface
    {
        private List<User> users = new List<User>();
        public void sendMessage(string msg, string userID)
        {
            User u = users.FirstOrDefault(u => u.getID() == userID);
            u.receive(msg);
        }

        public void addUser(User user)
        {
            this.users.Add(user);
        }
    }
}