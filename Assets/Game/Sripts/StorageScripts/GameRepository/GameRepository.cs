using System.Collections.Generic;
using Newtonsoft.Json;

public class GameRepository : IGameRepository
{
	private IRepositorySaveLoader _saveLoader;
	private const string GAME_STATE_KEY = "GameStateKey"; 
	private Dictionary<string, string> _gameState = new();
	public GameRepository(IRepositorySaveLoader saveLoader) => _saveLoader = saveLoader; 
	public void SetData<T>(T data)
	{
		string key = typeof(T).ToString();
		var serializeData = JsonConvert.SerializeObject(data);
		_gameState[key] = serializeData;
	}

	public bool TryGetData<T>(out T data)
	{
		string key = typeof(T).ToString();
		if (_gameState.TryGetValue(key, out string serializeData))
		{
			data = JsonConvert.DeserializeObject<T>(serializeData);
			return true;
		}
		data = default;
		return false;
	}
	public void SaveGame() => _saveLoader.SaveGame(GAME_STATE_KEY, _gameState);
	public void LoadGame() => _saveLoader.LoadGame(GAME_STATE_KEY, _gameState);
}