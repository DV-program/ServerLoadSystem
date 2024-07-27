using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PointSaveLoader : ISaveLoader
{
	private class PointData
	{
		public int Point;
	}
	public void LoadService(GameContext gameContext, IGameRepository repository)
	{
		if (repository.TryGetData(out PointData data))
		{
			var pointStorage = gameContext.GetService<PointStorage>();
			pointStorage.SetupPoint(data.Point);
			
		}
	}

	public void SaveService(GameContext gameContext, IGameRepository repository)
	{
		var pointStorage = gameContext.GetService<PointStorage>();
		repository.SetData(new PointData()
		{
			Point = pointStorage.GetValue()
		});
	}
}