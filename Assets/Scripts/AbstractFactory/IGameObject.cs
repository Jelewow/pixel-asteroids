using UnityEngine;

namespace Jelewow.Asteroids.AbstractFactory
{
    public interface IGameObject
    {
        Transform Transform { get; }
        
        Rigidbody2D Rigidbody { get; }
    }
}