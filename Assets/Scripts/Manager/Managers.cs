using System;
using Controller;
using SingleTon;

namespace Manager
{
    public class Managers : SingleTon<Managers>
    {
        private DataManager _dataManager;
        private GameManager _gameManager;
        private SpawnManager _spawnManager;
        private PoolManager _poolManager;
        private InputManager _inputManager;
        
        public static DataManager DataManager => Instance != null ? Instance._dataManager : null;
        public static GameManager GameManager => Instance != null ? Instance._gameManager : null;
        public static SpawnManager SpawnManager => Instance != null ? Instance._spawnManager : null;
        public static PoolManager PoolManager => Instance != null ? Instance._poolManager : null;
        public static InputManager InputManager => Instance != null ? Instance._inputManager : null;


        protected override void Awake()
        {
            base.Awake();

            //Manager 초기화
            _dataManager = GetComponent<DataManager>();
            _gameManager = GetComponent<GameManager>();
            _spawnManager = GetComponent<SpawnManager>();
            _poolManager = GetComponent<PoolManager>();
            _inputManager = GetComponent<InputManager>();

            //의존성 주입
            _dataManager.Init(new JsonLoader());
        }

        private void Update()
        {
            _inputManager.OnUpdate();
        }
    }
}