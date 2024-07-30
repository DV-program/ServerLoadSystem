using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PointStorage
{
	private int _value = 0;
	public int GetValue() => _value;
	public void SetupPoint(int value) => _value = value;
	public void PlusPoint() => _value += 1;
}