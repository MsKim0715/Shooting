
using UnityEngine;

namespace manager
{
    public class ManagerRunner : MonoBehaviour
    {
        private ManagerController _controller = ManagerController.Instance;
        private void Awake()
        {
            _controller.AwakeAll();
        }
    }
}