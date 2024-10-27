using Code.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Scripts.InteractableObjects
{
    public class InteractableLetterTrayWithCarrousel : InteractableWithCarrousel
    {
        [SerializeField] private Sprite[] _posibleLetters;
        
        protected override void Awake()
        {
            base.Awake();
        }
        
        public void AddLetter(int index)
        {
            //return if index was already added
            for (int i = 0; i < _sprite.Length; i++)
            {
                if (_sprite[i] == _posibleLetters[index])
                {
                    return;
                }
            }
            
            
            if (_sprite.Length == 0)
            {
                _sprite = new Sprite[1];
                _sprite[0] = _posibleLetters[index];
            }
            else
            {
                Sprite[] temp = new Sprite[_sprite.Length + 1];
                for (int i = 0; i < _sprite.Length; i++)
                {
                    temp[i] = _sprite[i];
                }
                temp[_sprite.Length] = _posibleLetters[index];
                _sprite = temp;
            }
        }
        
        public override void Interact()
        {
            if(_sprite.Length == 0)
                return;
            interactableWindow.gameObject.SetActive(true);
            interactableWindow.SetInteractableCarrouselWindow(this);
            interactableWindow.SetImage(_sprite[0]);
        }

        public override void PreviousImage()
        {
            base.PreviousImage();
        }
        
        public override void NextImage()
        {
            base.NextImage();
        }


    }
}