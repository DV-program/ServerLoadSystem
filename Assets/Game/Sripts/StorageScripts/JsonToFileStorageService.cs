using System;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using System.Threading.Tasks;

public class JsonToFileStorageService : IStorageService
{
	private bool _isInProgress = false;
	public void Load<T>(string key, Action<T> callback = null)
	{
		if (!_isInProgress)
		{
			LoadAsync<T>(key, callback);
		}
		else callback?.Invoke(default(T));
	}
	public async void LoadAsync<T>(string key, Action<T> callback)
	{
		string path = BuildPath(key);
		_isInProgress = true;
		using (var fileStream = new StreamReader(path))
		{
			string json = await fileStream.ReadToEndAsync();
			var data = JsonConvert.DeserializeObject<T>(json);
			callback?.Invoke(data);
		}
		
		_isInProgress = false;
	}

	public void Save(string key, object data, Action<bool> callback = null)
	{
		if (!_isInProgress)
		{
			SaveAsync(key, data, callback);
		}
		else callback?.Invoke(false);
	}
	private async void SaveAsync(string key, object data, Action<bool> callback) 
	{
		string path = BuildPath(key);
		string json = JsonConvert.SerializeObject(data);
		_isInProgress = true;
		using (var fileStream = new StreamWriter(path))
		{
			await fileStream.WriteAsync(json);
		}
		callback?.Invoke(true);
		_isInProgress = false;
	}
	private string BuildPath(string key)
	{
		return Path.Combine(Application.persistentDataPath, key);
	}
}