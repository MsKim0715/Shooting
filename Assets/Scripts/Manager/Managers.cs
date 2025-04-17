using Controller;
using SingleTon;

namespace Manager
{
    public class Managers : SingleTon<Managers>
    {
        private  DataManager _dataManager;
        private  GameManager _gameManager;

        public static DataManager DataManager => Instance != null ? Instance._dataManager : null;
        public static GameManager GameManager => Instance != null ? Instance._gameManager : null;


        protected override void Awake()
        {
            base.Awake();
            
            //Manager 초기화
            _dataManager = GetComponent<DataManager>();
            _gameManager = GetComponent<GameManager>();
            
            //의존성 주입
            _dataManager.Init(new JsonLoader());
        }
    }
}