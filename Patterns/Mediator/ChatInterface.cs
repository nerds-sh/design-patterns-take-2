namespace Patterns.Mediator
{
    public interface ChatInterface
    {
        public void sendMessage(String msg, String userID);
        void addUser(User user);
    }
}
