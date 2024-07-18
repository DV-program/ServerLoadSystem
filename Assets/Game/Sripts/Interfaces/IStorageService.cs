using System;

public interface IStorageService 
{
	public bool Save(string key, object data, Action callback = null);
	public bool Load(string key, Action callback);
}
