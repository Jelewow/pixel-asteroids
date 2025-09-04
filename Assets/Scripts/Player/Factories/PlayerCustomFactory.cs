using Jelewow.Asteroids.AbstractFactory;
using Jelewow.Asteroids.Player.MonoBehaviours;
using Jelewow.Asteroids.Player.ScriptableObjects;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.Player.Factories
{
    public class PlayerCustomFactory : ICustomFactory<PlayerView>
    {
        [Inject] private readonly DiContainer _container;

        [Inject] private readonly PlayerConfig _config;
        [Inject] private readonly PlayerView _prefab;
        [Inject] private readonly PlayerView.PlayerFactory _zenjectFactory;
        
        public PlayerView CreateObject(Vector3 position)
        {
            var player = _zenjectFactory.Create();
            // var player = _container.InstantiatePrefabForComponent<PlayerView>(_prefab);
            SetupPlayerInstance(player, position, _config);

            return player;
        }
        
        private void SetupPlayerInstance(PlayerView player, Vector3 position, PlayerConfig config)
        {
            if (!player)
            {
                return;
            }
            
            player.transform.position = position;

            player.Rigidbody.gravityScale = config.GravityScale;
            player.Rigidbody.linearDamping = config.LinearDamping;
        }
    }
}