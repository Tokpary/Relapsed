using UnityEngine;

namespace Code.Scripts.InteractableObjects
{
    public class InteractablePhone : InteractableObject
    {
        public override void Interact()
        {
            if (CallManager.Instance.IsRinging)
            {
                CallManager.Instance.PickUp();
            }
        }
    }
}