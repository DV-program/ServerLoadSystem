using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickerBootstrap : MonoBehaviour
{
	[SerializeField] private PointView _pointView;
	[SerializeField] private Button _clickButton;
	void Awake()
	{
		PointStorage pointStorage= new PointStorage();
		_pointView.Initialize();
		PointModel pointModel = new PointModel(_pointView, pointStorage);
		ButtonController pointController= new ButtonController(pointModel,_clickButton);
	}
}