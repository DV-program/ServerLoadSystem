
public interface IGameRepository 
{
	public void SetData<T>(T data);
	public bool TryGetData<T>(out T data);
}