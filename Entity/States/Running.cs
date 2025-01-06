using StatePattern.Entity.Interfaces;

namespace StatePattern.Entity.States {
    public class Running : IPersonState {
        public bool CanTransition(IState state) {
            if(state is Jumping || state is Walking)
                return true;  
            return false;
        }

        public void Handle() {
            Console.WriteLine("Running...");
        }
    }



}
