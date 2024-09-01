using System;
using Code.Configs;
using Code.Services.InputService;
using UnityEngine;
using Zenject;

namespace Code.Hero
{
    public class Movement: ITickable, IControllable
    {
        private CharacterController _controller;
        private HeroConfig _config;
        private Vector3 _moveDirection;

        public Movement(CharacterController controller, HeroConfig config)
        {
            _controller = controller;
            _config = config;
        }

        public void Tick() => Move(_moveDirection);

        public void Move(Vector3 direction) => _controller.Move(direction * _config.Speed * Time.deltaTime);
        
        public void Attack() => throw new ArgumentException("dibil");
    }
}