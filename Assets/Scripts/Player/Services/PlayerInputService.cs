using Jelewow.Asteroids.Player.Types;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.Player.Services
{
    public class PlayerInputService : ITickable
    {
        public PlayerInputData InputData { get; private set; }
        
        public void Tick()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            
            InputData = new PlayerInputData
            {
                Input = new Vector2
                {
                    x = vertical,
                    y = horizontal
                }
            };
        }
    }
}