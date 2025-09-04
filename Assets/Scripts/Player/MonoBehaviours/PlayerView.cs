using Jelewow.Asteroids.AbstractFactory;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.Player.MonoBehaviours
{
    public class PlayerView : MonoBehaviour
    {
        [field: SerializeField] 
        public Rigidbody2D Rigidbody { get; private set; }
        
        public class PlayerFactory : PlaceholderFactory<PlayerView>
        {
        
        }
    }
}