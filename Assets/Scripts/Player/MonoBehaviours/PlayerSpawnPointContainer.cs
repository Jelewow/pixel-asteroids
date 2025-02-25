using System;
using Jelewow.Asteroids.Extensions;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Jelewow.Asteroids.Player.MonoBehaviours
{
    public class PlayerSpawnPointContainer : MonoBehaviour
    {
        [SerializeField] private PlayerSpawnPoint[] _spawnPoints;

        private bool PointsExist => _spawnPoints == null || _spawnPoints.Length == 0;

        [ContextMenu("Fill spawn points")]
        private void FillSpawnPoints()
        {
            _spawnPoints = GetComponentsInChildren<PlayerSpawnPoint>();

            if (PointsExist)
            {
                throw new Exception("Don't find any player spawn points");
            }
        }

        public PlayerSpawnPoint GetRandomPoint()
        {
            if (PointsExist)
            {
                FillSpawnPoints();
            }

            if (_spawnPoints.IsCollectionValid())
            {
                FillSpawnPoints();
            }

            return _spawnPoints[Random.Range(0, _spawnPoints.Length)];
        }
    }
}