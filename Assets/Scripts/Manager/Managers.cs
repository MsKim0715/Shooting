using Controller;
using SingleTon;

namespace Manager
{
    public class Managers : SingleTon<Managers>
    {
        private readonly DataManager _dataManager = new(new JsonLoader());
        private readonly GameManager _gameManager = new();

        public static DataManager DataManager => Instance != null ? Instance._dataManager : null;
        public static GameManager GameManager => Instance != null ? Instance._gameManager : null;


    }
}