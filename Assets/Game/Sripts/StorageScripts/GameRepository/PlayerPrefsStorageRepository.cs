using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class PlayerPrefsStorageRepository : IRepositorySaveLoader
{
	public void LoadGame(string key, Dictionary<string, string> gameState)
	{
		if (PlayerPrefs.HasKey(key))
		{
			var serializedState = PlayerPrefs.GetString(key);
			gameState = JsonConvert.DeserializeObject<Dictionary<string, string>>(serializedState);
		}
		else Debug.Log("Save is not exist");
	}

	public void SaveGame(string key, Dictionary<string, string> gameState)
	{
		var serializedState = JsonConvert.SerializeObject(gameState);
		PlayerPrefs.SetString(key, serializedState);
	}
}