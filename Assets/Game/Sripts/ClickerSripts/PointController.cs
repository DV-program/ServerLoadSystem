using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class PointController 
{
	private Button _button;
	private PointModel _pointModel;
	public PointController(PointModel pointModel,Button button)
	{
		_button = button;
		_pointModel = pointModel;
		_button.onClick.AddListener(OnClick);
		
	}
	private void OnClick()
	{
		_pointModel.SetPlusPoint();
	}
}