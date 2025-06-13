using UnityEngine;
using locomotion.input;


namespace locomotion.state
{
    public class IdleState : IState
    {
        private readonly IInputReader _input;
        private readonly InputMovement _movement;
        private readonly StateMachine _fsm;

        public IdleState(IInputReader input, InputMovement movement, StateMachine fsm)
        {
            _input = input;
            _movement = movement;
            _fsm = fsm;
        }

        public void Enter() { }
        public void Exit() { }

        public void Update()
        {
            if (_input.GetMoveDirection() != Vector2.zero)
            {
                _fsm.StateChange(new MoveState(_input, _movement, _fsm));
            }
        }
    }
}