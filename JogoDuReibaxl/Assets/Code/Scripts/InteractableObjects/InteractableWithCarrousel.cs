using Code.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Scripts.InteractableObjects
{
    public class InteractableWithCarrousel : InteractableObject
    {
        [SerializeField] protected Sprite[] _sprite;
        protected InteractableCarrouselWindow interactableWindow;
        protected int _currentImageIndex = 0;
        
        protected virtual void Awake()
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
        
        public virtual void NextImage()
        {
            if (_currentImageIndex + 1 >= _sprite.Length)
            {
                _currentImageIndex = 0;
            }
            else
            {
                _currentImageIndex++;
            }
            Debug.Log(_currentImageIndex);
            Debug.Log(_sprite.Length);
            Debug.Log(interactableWindow);
            interactableWindow.SetImage(_sprite[_currentImageIndex]);
        }
        
        public virtual void PreviousImage()
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