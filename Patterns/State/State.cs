
using Patterns.StateClasses;

namespace Patterns {
    class State {
        public static void Run() {
            var context = new Context(new Worker());
            context.Request(0);
            context.Request(0);
            context.Request(1);
        }
    }
}
