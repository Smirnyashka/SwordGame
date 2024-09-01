using UnityEngine;

namespace Code.Services.InputService
{
    public interface IControllable
    {
        void Move(Vector3 direction);
        void Attack();
    }
}