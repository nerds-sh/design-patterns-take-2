
namespace Patterns.StateClasses {
    abstract class State
    {
        protected Context _context;
        public void SetContext(Context context) {
            this._context = context;
        }

        public abstract void Handle(int index);
    }

    class Context {
        private State _state = null;
        public Context(State state) {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state) {
            this._state = state;
            this._state.SetContext(this);
        }

        public void Request(int index) {
            this._state.Handle(index);
        }
    }
}