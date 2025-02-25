using Jelewow.Asteroids.Player.Types;

namespace Jelewow.Asteroids.Player.Services.Movement
{
    public interface IMovementStrategy
    {
        public void Move(PlayerInputData inputData);
    }
}