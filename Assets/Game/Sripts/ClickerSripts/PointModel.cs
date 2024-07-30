using System.Drawing;
using UnityEngine;
public class PointModel : IButtonModel
{
	private PointView _pointView;
	private PointStorage _pointStorage;
	public PointModel(PointView pointView, PointStorage pointStorage)
	{
		_pointStorage = pointStorage;
		_pointView = pointView;
		_pointView.Display(_pointStorage.GetValue());
	}
    public void OnClicked()
	{
		_pointStorage.PlusPoint();
		_pointView.Display(_pointStorage.GetValue());
	}
}