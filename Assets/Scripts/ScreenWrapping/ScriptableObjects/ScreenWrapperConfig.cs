using UnityEngine;

namespace Jelewow.Asteroids.ScreenWrapping.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Asteroids/ScreenWrapper/Config", fileName = "New ScreenWrapper Config")]
    public class ScreenWrapperConfig : ScriptableObject
    {
        [field: SerializeField]
        public Vector2 BorderX { get; private set; }
        
        [field: SerializeField]
        public Vector2 BorderY { get; private set; }
    }
}