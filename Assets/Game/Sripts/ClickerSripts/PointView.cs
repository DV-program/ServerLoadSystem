using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointView : MonoBehaviour
{
	private TMP_Text _scoreText;
	public void Initialize() => _scoreText = GetComponent<TMP_Text>();
	public void Display(int value) => _scoreText.text = value.ToString(); 
}
