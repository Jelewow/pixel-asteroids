using Jelewow.Asteroids.ScreenWrapping.Factories;
using Jelewow.Asteroids.ScreenWrapping.ScriptableObjects;
using Jelewow.Asteroids.ScreenWrapping.Services;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.ScreenWrapping.MonoBehaviours
{
    [DisallowMultipleComponent]
    public class ScreenWrapper : MonoBehaviour
    {
        [Inject] private readonly DiContainer _container;
        [Inject] private readonly ScreenWrapperFactory _screenWrapperFactory;

        [SerializeField] private ScreenWrapperConfig _config;
        
        private void Start()
        {
            var service = _screenWrapperFactory.Create(_config, transform);
            
            _container.Bind<ITickable>().FromInstance(service).AsTransient();
            _container.Resolve<TickableManager>().Add(service);
        }
    }
}