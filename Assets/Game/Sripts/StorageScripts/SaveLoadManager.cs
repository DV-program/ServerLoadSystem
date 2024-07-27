using UnityEngine;

public class SaveLoadManager 
{
	private ISaveLoader[] _saveLoaders;
	private GameContext _gameContext;
	public SaveLoadManager(ISaveLoader[] saveLoaders, GameContext gameContext)
	{
		_saveLoaders = saveLoaders;
		_gameContext = gameContext;
	}
	public void SaveGame()
	{
		foreach (var saver in _saveLoaders)
		{
			saver.SaveService(_gameContext);
		}
	}
	public void LoadGame()
	{
		foreach (var loader in _saveLoaders)
		{
			loader.LoadService(_gameContext);
		}
	}
}