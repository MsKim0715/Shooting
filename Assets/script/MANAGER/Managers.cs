using CONTROLLER;
using MANAGER.INTERFACE;
using SINGLETON;

namespace MANAGER
{
    
    public class Managers : SingleTon<Managers>
    {
        private IDataManager _dataManager;
        private ISpawnManager _spawnManager;
        private IInputManager _inputManager;
        private IResourceManager _resourceManager;
        public static IDataManager DataManager => Instance != null ? Instance._dataManager : null;
        public static ISpawnManager SpawnManager => Instance != null ? Instance._spawnManager : null;
        public static IInputManager InputManager => Instance != null ? Instance._inputManager : null;
        public static IResourceManager ResourceManager => Instance != null ? Instance._resourceManager : null;

        protected override void Awake()
        {
            base.Awake();

            //Manager 초기화
            _dataManager = GetComponent<DataManager>();
            _spawnManager = GetComponent<SpawnManager>();
            _inputManager = GetComponent<InputManager>();
            _resourceManager = GetComponent<ResourceManager>();
            

            //의존성 주입
            _dataManager.Init(new JsonLoader());
        }
        
    }
}