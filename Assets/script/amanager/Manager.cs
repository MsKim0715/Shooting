

namespace manager
{
    public abstract class Manager
    {
        /* 매니저 커스텀 생명주기 메서드 */
        public virtual void OnAwake(){}
        public virtual void OnStart(){}
        public virtual void OnUpdate(){}
        public virtual void OnFixedUpdate(){}
    }
}
 