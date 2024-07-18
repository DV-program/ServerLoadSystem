using System;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class JsonToFileStorageService : IStorageService
{
	public bool Load(string key, Action callback)
	{
		string path = BuildPath(key);
	}

	public bool Save(string key, object data, Action callback = null)
	{
		string path = BuildPath(key);
		string json = JsonConvert.SerializeObject(data);
	}
	private string BuildPath(string key)
	{
		return Path.Combine(Application.persistentDataPath, key);
	}
}