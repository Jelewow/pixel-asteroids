using Jelewow.Asteroids.AbstractFactory;
using Jelewow.Asteroids.Player.MonoBehaviours;
using Zenject;

namespace Jelewow.Asteroids.Player.Factories
{
    public class PlayerFactoryInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.Bind<ICustomFactory<PlayerView>>().To<PlayerCustomFactory>().AsSingle();
        }
    }
}