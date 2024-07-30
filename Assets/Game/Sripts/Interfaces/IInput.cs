using System;
using UnityEngine;

namespace Assets.Game.Interfaces
{
	public interface IInput
	{
		public Vector2 MoveRegister();
		public bool ClickRegister();
	}
}