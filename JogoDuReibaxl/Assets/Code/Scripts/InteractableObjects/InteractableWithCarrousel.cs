using Code.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Scripts.InteractableObjects
{
    public class InteractableWithCarrousel : InteractableObject
    {
        [SerializeField] private Sprite[] _sprite;
        private InteractableCarrouselWindow interactableWindow;
        private int _currentImageIndex = 0;
        
        private void Awake()
        {
            interactableWindow = GameObject.Find("InteractableCarrouselVisualizer").GetComponent<InteractableCarrouselWindow>();
        }
        
        public override void Interact()
        {
            base.Interact();
            interactableWindow.gameObject.SetActive(true);
            interactableWindow.SetInteractableCarrouselWindow(this);
            interactableWindow.SetImage(_sprite[0]);
        }
        
        public void NextImage()
        {
            if (_currentImageIndex + 1 >= _sprite.Length)
            {
                _currentImageIndex = 0;
            }
            else
            {
                _currentImageIndex++;
            }
            interactableWindow.SetImage(_sprite[_currentImageIndex]);
        }
        
        public void PreviousImage()
        {
            if (_currentImageIndex - 1 < 0)
            {
                _currentImageIndex = _sprite.Length - 1;
            }
            else
            {
                _currentImageIndex--;
            }
            interactableWindow.SetImage(_sprite[_currentImageIndex]);
        }
        

    }
}