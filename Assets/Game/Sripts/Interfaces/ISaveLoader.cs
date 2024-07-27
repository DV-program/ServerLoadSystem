using System;
public interface ISaveLoader 
{
	public void LoadService(GameContext gameContext);
	public void SaveService(GameContext gameContext);
}