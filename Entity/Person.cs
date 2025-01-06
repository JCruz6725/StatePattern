using StatePattern.Entity.Interfaces;
using StatePattern.Entity.States;

namespace StatePattern.Entity {
    internal class Person {
        public Person(IState initailState ) {
            CurrentState = initailState;
        }

        private IState CurrentState { get; set; }
 
        public void Set_State(IState transitionState) {
            if(!CurrentState.CanTransition(transitionState)) {
                throw new Exception($"Transition {CurrentState.GetType().ToString()} -> {transitionState.GetType().ToString()} is not possible");
            }
            CurrentState = transitionState;
        }

        public void Execute() {
            CurrentState.Handle();
        }

        public void ChangeAndExecute(IState state) { 
            Set_State(state);
            Execute();
        
        }
    }
}
