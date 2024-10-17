using System;
using Code.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Code.Scripts.InteractableObjects
{
    public class InteractableObject : MonoBehaviour, IInteractable
    {
        Material _interactableMaterial;
        Renderer _renderer;

        protected void Awake()
        {
            //_interactableMaterial = UnityEngine.Resources.Load<Material>("ShadersMat/HighlightShaderMat");
            _renderer = GetComponent<Renderer>();
        }

        public virtual void Interact()
        {
            Debug.Log($"Interacted with {gameObject.name}");
        }

        public virtual void Highlight()
        {
            //_renderer.materials[1] = _interactableMaterial;
            Debug.Log($"Highlighted {gameObject.name}");
        }

        private void OnMouseDown()
        {
            Interact();
        }

        private void OnMouseEnter()
        {
            Highlight();
        }
    }
}