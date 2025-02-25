﻿using System;
using Jelewow.Asteroids.Player.MonoBehaviours;
using Jelewow.Asteroids.Player.ScriptableObjects;
using UnityEngine;
using Zenject;

namespace Jelewow.Asteroids.Player.Services
{
    public class PlayerInstanceService
    {
        [Inject] private readonly DiContainer _diContainer;

        [Inject] private readonly PlayerConfig _playerConfig;
        [Inject] private readonly PlayerView _playerViewPrefab;
        
        public PlayerView PlayerViewInstance { get; private set; }
        
        public PlayerView CreatePlayer(Vector3 position)
        {
            if (PlayerViewInstance)
            {
                throw new Exception("Player already spawned");
            }

            PlayerViewInstance = _diContainer.InstantiatePrefabForComponent<PlayerView>(_playerViewPrefab);
            SetupPlayerInstance(position, _playerConfig);

            return PlayerViewInstance;
        }

        private void SetupPlayerInstance(Vector3 position, PlayerConfig config)
        {
            if (!PlayerViewInstance)
            {
                return;
            }
            
            PlayerViewInstance.transform.position = position;

            PlayerViewInstance.Rigidbody.gravityScale = config.GravityScale;
            PlayerViewInstance.Rigidbody.linearDamping = config.LinearDamping;
        }
    }
}