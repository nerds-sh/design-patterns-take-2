
namespace Patterns.StateClasses {
    class Aparat : State {
        public override void Handle(int index)
        {
            switch(index) {
                case 0:
                    Console.WriteLine("Finished work, notifying worker.");
                    this._context.TransitionTo(new Worker());
                    break;
                default:
                    break;
            }
        }
    }

    class Worker : State {
        public override void Handle(int index)
        {
            switch(index) {
                case 0:
                    Console.WriteLine("Starting work...");
                    this._context.TransitionTo(new Aparat());
                    break;
                case 1:
                    Console.WriteLine("Woke up, done.");
                    break;
                default:
                    break;
            }
        }
    }
}