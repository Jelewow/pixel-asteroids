using Jelewow.Asteroids.AbstractFactory;
using Jelewow.Asteroids.Player.MonoBehaviours;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.Player.Services
{
    public class PlayerInstanceService
    {
        [Inject] private readonly ICustomFactory<PlayerView> _playerCustomFactory;
        
        public PlayerView Player { get; private set; }
        
        public void CreatePlayer(Vector3 position)
        {
            Player = _playerCustomFactory.CreateObject(position);
        }
    }
}