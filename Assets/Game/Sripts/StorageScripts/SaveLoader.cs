using UnityEngine;

public abstract class SaveLoader<TData, TService> : ISaveLoader where TService : IService
{
	public void LoadService(GameContext gameContext, IGameRepository repository)
	{
		if (repository.TryGetData(out TData data))
		{
			var service = gameContext.GetService<TService>();
			SetupData(data, service);
		}
	}

	public void SaveService(GameContext gameContext, IGameRepository repository)
	{
		var service = gameContext.GetService<TService>();
		TData data = ConvertToData(service);
		repository.SetData(data);
	}
	protected abstract void SetupData(TData data, TService service);
	protected abstract TData ConvertToData(TService service);
}