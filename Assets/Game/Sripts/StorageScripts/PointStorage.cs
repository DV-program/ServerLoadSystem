using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PointStorage : IService
{
	private int _value = 0;
	public int GetValue() => _value;
	public void SetupPoint(int value) => _value = value;
}