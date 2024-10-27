using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Code.Scripts.InteractableObjects
{
    public class InteractableCarrouselWindow : MonoBehaviour, IPointerDownHandler
    {
        private RawImage _imagePlaceHolder;
        InteractableWithCarrousel _interactableWithCarrousel;
        
        public void SetInteractableCarrouselWindow(InteractableWithCarrousel interactableWithCarrousel)
        {
            _interactableWithCarrousel = interactableWithCarrousel;
        }
        
        public void NextImage()
        {
            _interactableWithCarrousel.NextImage();
        }
        
        public void PreviousImage()
        {
            _interactableWithCarrousel.PreviousImage();
        }
        
        
        private void Start()
        {
            _imagePlaceHolder = GetComponentInChildren<RawImage>();
            gameObject.SetActive(false);
        }
        
        public void SetImage(Sprite sprite)
        {
            _imagePlaceHolder.texture = sprite.texture;
        }


        public void OnPointerDown(PointerEventData eventData)
        {
            gameObject.SetActive(false);
        }
    }
}
