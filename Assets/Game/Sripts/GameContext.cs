using UnityEngine;
using System.Collections.Generic;
using System;

public class GameContext
{
	private readonly Dictionary<string, IService> _services; 
	public GameContext()
	{
		_services = new();
	}
	public void Register<T>(T service) where T : IService
	{
		string key = typeof(T).Name;
		if (_services.ContainsKey(key))
		{
			Debug.LogError($"Attempt to overwrite an existing dictionary element {key}");
			return;
		}
		_services.Add(key, service);
	}
	public void UnRegister<T>(T service) where T : IService
	{
		string key = typeof(T).Name;
		if (!_services.ContainsKey(key))
		{
			Debug.LogError($"Attempt to delete a non-existent dictionary element {key}");
			return;
		}
		_services.Remove(key);
	}
	public T GetService<T>() where T : IService
	{
		string key = typeof(T).Name;
		if (!_services.ContainsKey(key))
		{
			Debug.LogError($"attempt to call a non-existent dictionary element {key}");
			throw new InvalidOperationException();
		}
		return (T)_services[key];
	}
}