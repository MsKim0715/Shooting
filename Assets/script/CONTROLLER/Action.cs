namespace CONTROLLER
{
    public interface IAction<in T>
    {
        void Execute(T data);
    }
}