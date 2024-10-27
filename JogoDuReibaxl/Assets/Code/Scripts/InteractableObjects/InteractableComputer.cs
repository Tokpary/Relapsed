using UnityEngine;

namespace Code.Scripts.InteractableObjects
{
    public class InteractableComputer : InteractableObject
    {
        [SerializeField] Transform _screenTarget;
        public override void Interact()
        {
            CameraMovementManager.Instance.LookAt(_screenTarget);
        }
    }
}