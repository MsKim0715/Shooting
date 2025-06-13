using System.Collections;
using locomotion.input;
using locomotion.state;


namespace locomotion
{
    public class InputMovement : MoveBase
    {
        private StateMachine _stateMachine;
        private IInputReader _inputReader;
        protected override void Awake()
        {
            base.Awake();
            _inputReader = GetComponent<InputReader>();
            _stateMachine = new StateMachine();
        }

        private void Start()
        {
            _stateMachine.StateChange(new IdleState(_inputReader, this, _stateMachine));
        }

        private void Update()
        {
            _stateMachine.Update();
        }
    }
}