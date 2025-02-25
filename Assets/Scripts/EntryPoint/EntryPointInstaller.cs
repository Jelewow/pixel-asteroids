using Jelewow.Asteroids.EntryPoint.Scenarios;
using Jelewow.Asteroids.Extensions;
using Jelewow.Asteroids.Player.MonoBehaviours;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.EntryPoint
{
    public class EntryPointInstaller : MonoInstaller
    {
        [SerializeField] private PlayerSpawnPointContainer _playerSpawnPointContainer;
        
        public override void InstallBindings()
        {
            Container.BindObjectOnScene(_playerSpawnPointContainer);
            Container.BindScenario<EntryPointScenario>();
        }
    }
}