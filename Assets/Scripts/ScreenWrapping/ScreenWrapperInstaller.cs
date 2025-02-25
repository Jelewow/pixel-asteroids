using Jelewow.Asteroids.ScreenWrapping.Factories;
using Jelewow.Asteroids.ScreenWrapping.ScriptableObjects;
using Jelewow.Asteroids.ScreenWrapping.Services;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.ScreenWrapping
{
    public class ScreenWrapperInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindFactory<ScreenWrapperConfig, Transform, ScreenWrapperService, ScreenWrapperFactory>().AsSingle();
        }
    }
}