namespace locomotion.state
{
    public interface IState
    {
        void Enter();
        void Update();
        void Exit();
    }
}