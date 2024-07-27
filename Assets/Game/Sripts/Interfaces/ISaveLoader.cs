using System;
public interface ISaveLoader 
{
	public void LoadService(GameContext gameContext, IGameRepository repository);
	public void SaveService(GameContext gameContext, IGameRepository repository);
}