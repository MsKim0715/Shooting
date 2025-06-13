using command;
using locomotion.input;
using UnityEngine;
namespace locomotion.state
{
    public class MoveState : IState
    {
        private readonly IInputReader _input;
        private readonly InputMovement _movement;
        private readonly StateMachine _fsm;

        public MoveState(IInputReader input, InputMovement movement, StateMachine fsm)
        {
            _input = input;
            _movement = movement;
            _fsm = fsm;
        }

        public void Enter() { }

        public void Exit()
        {
            _movement.Movement.SetVelocity(Vector2.zero);
        }

        public void Update()
        {
            Vector2 dir = _input.GetMoveDirection();

            if (dir == Vector2.zero)
            {
                _fsm.StateChange(new IdleState(_input, _movement, _fsm));
            }
            else
            {
                var moveCmd = new MoveCommandInput(_movement.Movement, dir, _movement.MoveSpeed);
                moveCmd.Execute();
            }
        }
    }
}