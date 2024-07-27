using System.Collections.Generic;

public interface IRepositorySaveLoader 
{
	public void SaveGame(string key, Dictionary<string, string> data);
	public void LoadGame(string key, Dictionary<string, string> data);
}