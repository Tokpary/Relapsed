using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Code.Scripts.InteractableObjects
{
    public class InteractableWindow : MonoBehaviour, IPointerDownHandler
    {
        private RawImage _imagePlaceHolder;
        
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
