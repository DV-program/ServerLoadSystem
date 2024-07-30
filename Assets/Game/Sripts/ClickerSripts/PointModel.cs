using System.Drawing;
using UnityEngine;
public class PointModel 
{
	private PointView _pointView;
	private PointStorage _pointStorage;
	public PointModel(PointView pointView, PointStorage pointStorage)
	{
		_pointStorage = pointStorage;
		_pointView = pointView;
		_pointView.Display(_pointStorage.GetValue());
	}
	public void SetPlusPoint()
	{
		_pointStorage.PlusPoint();
		_pointView.Display(_pointStorage.GetValue());
	}
}