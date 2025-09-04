using Jelewow.Asteroids.Enemy.Services;
using Jelewow.Asteroids.Extensions;
using Zenject;

namespace Jelewow.Asteroids.Enemy
{
    public class EnemyInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindService<EnemyMoveService>();
        }
    }
}