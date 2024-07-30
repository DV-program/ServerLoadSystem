using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class ButtonController 
{
	private Button _button;
	private IButtonModel _buttonModel;
	public ButtonController(IButtonModel buttonModel,Button button)
	{
		_button = button;
		_buttonModel = buttonModel;
		_button.onClick.AddListener(OnClick);
	}
	private void OnClick()
	{
		_buttonModel.OnClicked();
	}
}