using UnityEngine;

public class SaveLoadManager 
{
	private ISaveLoader[] _saveLoaders;
	private GameContext _gameContext;
	private GameRepository _gameRepository;
	public SaveLoadManager(ISaveLoader[] saveLoaders, GameContext gameContext, GameRepository gameRepository)
	{
		_saveLoaders = saveLoaders;
		_gameContext = gameContext;
		_gameRepository = gameRepository;
	}
	public void SaveGame()
	{
		foreach (var saver in _saveLoaders)
		{
			saver.SaveService(_gameContext, _gameRepository);
		}
		_gameRepository.SaveGame();
	}
	public void LoadGame()
	{
		_gameRepository.LoadGame();
		foreach (var loader in _saveLoaders)
		{
			loader.LoadService(_gameContext, _gameRepository);
		}
	}
}