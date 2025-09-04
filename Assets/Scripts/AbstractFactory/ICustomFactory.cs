using UnityEngine;

namespace Jelewow.Asteroids.AbstractFactory
{
    public interface ICustomFactory<T>
    {
        T CreateObject(Vector3 position);
    }
}