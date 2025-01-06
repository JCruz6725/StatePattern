using StatePattern.Entity.Interfaces;

namespace StatePattern.Entity.States {
    public class Jumping : IPersonState {
        public bool CanTransition(IState state) {
            if(state is Running)
                return true;
            return false;
        }

        public void Handle() {
            Console.WriteLine("Jumping...");
        }
    }
}
