using UnityEngine;

namespace Jelewow.Asteroids.Player.MonoBehaviours
{
    public class PlayerView : MonoBehaviour
    {
        [field: SerializeField] 
        public Rigidbody2D Rigidbody { get; private set; }
    }
}