using System;
using UnityEngine;

namespace Assets.Game.Sripts
{
    public class EventBus
    {
        private static EventBus _instance;
        public static EventBus Instance
        {
            get
            {
                if (_instance == null) { _instance = new(); }
                return _instance;
            }
        }
        public Action PlayerDied;
        // InputSystem
        public Action<Vector2> ButtonsRegistred;
        public Action Update;
        public Action FixedUpdate;
        // Key
        // Door
        public Action PlayerEntering;
        // Level
        public Action LevelRestarting;
    }
}