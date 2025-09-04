using Jelewow.Asteroids.AbstractFactory;
using Jelewow.Asteroids.Player.MonoBehaviours;
using Jelewow.Asteroids.Player.ScriptableObjects;
using Jelewow.Asteroids.Player.Types;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.Player.Services.Movement
{
    public class PhysicsMovementStrategy : IMovementStrategy
    {
        [Inject] private readonly PlayerConfig _config;
        [Inject] private readonly PlayerInstanceService _playerInstanceService;
        
        public void Move(PlayerInputData inputData)
        {
            var playerInstance = _playerInstanceService.Player;
            
            Moving(inputData, playerInstance);
            Rotating(inputData, playerInstance);
        }

        private void Moving(PlayerInputData inputData, PlayerView player)
        {
            var force = _config.Acceleration * player.transform.up;
            var moveDirection = Mathf.Clamp(inputData.Input.x, 0f, 1f);
            
            player.Rigidbody.AddForce(force * moveDirection);
            player.Rigidbody.linearVelocity = Vector2.ClampMagnitude(player.Rigidbody.linearVelocity, _config.MaxVelocity);
        }

        private void Rotating(PlayerInputData inputData, PlayerView player)
        {
            var rotateDirection = -inputData.Input.y * Time.deltaTime * _config.RotationSpeed;
            player.transform.Rotate(rotateDirection * player.transform.forward);
        }
    }
}