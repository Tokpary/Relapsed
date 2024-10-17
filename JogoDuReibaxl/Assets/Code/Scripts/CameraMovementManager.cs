using System;
using DG.Tweening;
using Resources.Code.Scripts.DesignPatterns.Singleton;
using UnityEngine;

namespace Code.Scripts
{
    public class CameraMovementManager : Singleton<CameraMovementManager>
    {
        private Camera _camera;
        [SerializeField] private float _duration = 0.75f;
        [SerializeField] private Ease _ease = Ease.InOutBack;
        private void Start()
        {
            _camera = Camera.main;
        }
        
        public void MoveCamera(Vector3 rotation, Vector3 position)
        {
            _camera.transform.DOMove(position, _duration).SetEase(_ease);
            _camera.transform.DORotate(rotation, _duration).SetEase(_ease);
        }
    }
}
