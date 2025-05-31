using manager;
using UnityEngine;

namespace bootStrapper
{

    public class BootStrapper
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void ManagerInit()
        {
            ManagerController controller = ManagerController.Instance;
            
            /* 여기서 등록하고 싶은 매니저 등록 */
            controller.Register("TestManager", new TestManager());
        }
        
    }
}

    
    

