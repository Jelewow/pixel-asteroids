using Jelewow.Asteroids.ScreenWrapping.ScriptableObjects;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.ScreenWrapping.Services
{
    public class ScreenWrapperService : ITickable
    {
        private readonly ScreenWrapperConfig _config;
        private readonly Transform _target;
        private readonly Camera _camera;

        public ScreenWrapperService(ScreenWrapperConfig config, Transform target)
        {
            _config = config;
            _target = target;

            _camera = Camera.main;
        }

        public void Tick()
        {
            var viewportPosition = _camera.WorldToViewportPoint(_target.position);
            var positionAdjustment = Vector3.zero;

            if (viewportPosition.x < _config.BorderX.x)
            {
                positionAdjustment.x = _config.BorderX.y - _config.BorderX.x;
            }
            else if(viewportPosition.x > _config.BorderX.y)
            {
                positionAdjustment.x = _config.BorderX.x - _config.BorderX.y;
            }
            else if (viewportPosition.y < _config.BorderY.x)
            {
                positionAdjustment.y = _config.BorderY.y - _config.BorderY.x;
            }
            else if(viewportPosition.y > _config.BorderY.y)
            {
                positionAdjustment.y = _config.BorderY.x - _config.BorderY.y;
            }

            var newViewportPosition = viewportPosition + positionAdjustment;
            _target.position = _camera.ViewportToWorldPoint(newViewportPosition);
        }
    }
}