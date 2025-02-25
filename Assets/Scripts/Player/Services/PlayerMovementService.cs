using Jelewow.Asteroids.Player.Services.Movement;
using Jelewow.Asteroids.Player.Types;
using Zenject;

namespace Jelewow.Asteroids.Player.Services
{
    public class PlayerMovementService : ITickable, IFixedTickable
    {
        [Inject] private readonly PlayerInputService _inputService;
        [Inject] private readonly IMovementStrategy _movementStrategy;
        
        private PlayerInputData _inputData;
        
        public void Tick()
        {
            _inputData = _inputService.InputData;
        }

        public void FixedTick()
        {
            _movementStrategy.Move(_inputData);
        }
    }
}