namespace Patterns.Mediator
{
    public class ChatRun
    {
        public static void main(String[] args)
        {
            ChatInterface chatroom = new ChatRoom();

            User user1 = new ChatUser(chatroom, "1", "Mihai");
            User user2 = new ChatUser(chatroom,"2", "Alina");
            User user3 = new ChatUser(chatroom,"3", "Maria");
            User user4 = new ChatUser(chatroom,"4", "David");

            chatroom.addUser(user1);
            chatroom.addUser(user2);
            chatroom.addUser(user3);
            chatroom.addUser(user4);

            user1.send("Hello brian", "2");
            user2.send("Hey buddy", "1");
        }
    }
}