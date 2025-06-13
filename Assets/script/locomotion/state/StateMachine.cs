namespace locomotion.state
{
    public class StateMachine
    {
        private IState _current;
        
        public void StateChange(IState newState) 
        {
            _current?.Exit();
            _current = newState;
            _current?.Enter();
        }

        public void Update()
        {
            _current?.Update();
        }
    }
}