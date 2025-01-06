namespace StatePattern.Entity.Interfaces {
    // Base interface for states state
    public interface IState {
        public bool CanTransition(IState state);
        public void Handle();
    }



}
