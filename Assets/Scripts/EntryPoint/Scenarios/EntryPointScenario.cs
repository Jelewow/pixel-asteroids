using Jelewow.Asteroids.Player.MonoBehaviours;
using Jelewow.Asteroids.Player.Services;
using Zenject;

namespace Jelewow.Asteroids.EntryPoint.Scenarios
{
    public class EntryPointScenario : IInitializable
    {
        [Inject] private readonly PlayerInstanceService _playerInstanceService;
        [Inject] private readonly PlayerSpawnPointContainer _playerSpawnPointContainer;
        
        public void Initialize()
        {
            var playerSpawnPoint = _playerSpawnPointContainer.GetRandomPoint();
            _playerInstanceService.CreatePlayer(playerSpawnPoint.Position);
        }
    }
}