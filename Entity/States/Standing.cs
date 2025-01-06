using StatePattern.Entity.Interfaces;

namespace StatePattern.Entity.States {
    public class Standing : IPersonState {
        public bool CanTransition(IState state) {
            if (state is Walking)
                return true;
            return false;
            
        }

        public void Handle() {
            Console.WriteLine("Standing...");
        }
    }



}
