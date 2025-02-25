using Jelewow.Asteroids.Extensions;
using Jelewow.Asteroids.Player.MonoBehaviours;
using Jelewow.Asteroids.Player.ScriptableObjects;
using Jelewow.Asteroids.Player.Services;
using Jelewow.Asteroids.Player.Services.Movement;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.Player
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerConfig _playerConfig;
        [SerializeField] private PlayerView _playerView;

        public override void InstallBindings()
        {
            Container.BindPrefab(_playerView);
            Container.BindService<PlayerInstanceService>();
            
            Container.BindService<PlayerInputService>();
            Container.BindScriptableObject(_playerConfig);
            
            Container.BindService<PhysicsMovementStrategy>();
            Container.BindService<PlayerMovementService>();
        }
    }
}