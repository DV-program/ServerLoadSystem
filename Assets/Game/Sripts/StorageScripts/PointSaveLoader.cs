using System;
using UnityEngine;

public class PointSaveLoader : ISaveLoader
{
	public void LoadService(GameContext gameContext)
	{
		if (PlayerPrefs.HasKey("Clicker/Score"))
		{
			int value = PlayerPrefs.GetInt("Clicker/Score");
			var pointStorage = gameContext.Get<PointStorage>();
			pointStorage.SetupPoint(value);
		}
	}

	public void SaveService(GameContext gameContext)
	{
		var pointStorage = gameContext.Get<PointStorage>();
		PlayerPrefs.SetInt("Clicker/Score", pointStorage.GetValue());
	}
}