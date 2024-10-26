using Code.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Scripts.InteractableObjects
{
    public class InteractableWithCarrousel : InteractableObject
    {
        [SerializeField] private Sprite[] _sprite;
        private InteractableWindow interactableWindow;
        
        private void Awake()
        {
            interactableWindow = GameObject.Find("InteractableCarrouselVisualizer").GetComponent<InteractableWindow>();
        }
        
        public override void Interact()
        {
            base.Interact();
            interactableWindow.gameObject.SetActive(true);
            interactableWindow.SetImage(_sprite[0]);
        }
        

    }
}