using Assets.Game.Interfaces;
using UnityEngine;
namespace Assets.Game.Sripts
{
    public class InputPC : IInput
    {
        public bool ClickRegister()
        {
            throw new System.NotImplementedException();
        }

        public Vector2 MoveRegister()
        {
            float horizontalMove = Input.GetAxis("Horizontal");
            float verticalMove = Input.GetAxis("Vertical");
            return new Vector2(horizontalMove, verticalMove);
        }
    }
}