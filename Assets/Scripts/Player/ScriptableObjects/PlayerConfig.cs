using UnityEngine;

namespace Jelewow.Asteroids.Player.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Asteroids/Player/Config", fileName = "Player Config")]
    public class PlayerConfig : ScriptableObject
    {
        [Header("Movement")]
        [field: SerializeField] 
        public float Acceleration { get; private set; }
        
        [field: SerializeField] 
        public float MaxVelocity { get; private set; }
        
        [field: SerializeField] 
        public float RotationSpeed { get; private set; }

        [Header("Physics")]
        [field: SerializeField] 
        public float LinearDamping { get; private set; }
        
        [field: SerializeField] 
        public float GravityScale { get; private set; }
    }
}