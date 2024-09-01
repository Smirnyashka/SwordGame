using UnityEngine;
using Zenject;

namespace Code.Services.InputService
{
    public class SimpleInput: ITickable
    {
        private readonly IControllable _controllable;
        private readonly GameInput _gameInput;

        public SimpleInput(IControllable controllable, GameInput gameInput)
        {
            _controllable = controllable;
            _gameInput = gameInput;
            _gameInput.Enable();
        }

        public void Tick() => ReadMovement();

        private void ReadMovement()
        {
            var inputDirection = _gameInput.GamePlay.Movement.ReadValue<Vector3>();
            var direction = new Vector3(inputDirection.x, 0f, inputDirection.y);

            _controllable.Move(direction);
        }
    }
}