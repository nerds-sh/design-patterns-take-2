namespace Patterns.Mediator
{
    public abstract class User
    {
        private ChatInterface mediator;
        private string id;
        private string name;

        public User(ChatInterface room, string id, string name)
        {
            this.mediator = room;
            this.name = name;
            this.id = id; 
        }

        public abstract void send(string msg, string userID);
        public abstract void receive(string msg);

        public ChatInterface getMediatou()
        {
            return mediator;
        }

        public string getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }
    }
}