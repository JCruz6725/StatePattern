using StatePattern.Entity.Interfaces;

namespace StatePattern.Entity.States {
    public class Walking : IPersonState {
        public bool CanTransition(IState state) {
            if (state is Standing || state is Running) 
                return true; 
            return false;
        }

        public void Handle() {
            Console.WriteLine("Walking...");
        }
    }
}
