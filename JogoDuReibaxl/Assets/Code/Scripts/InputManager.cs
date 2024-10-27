using System;
using Code.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Code.Scripts
{
    public class InputManager : MonoBehaviour
    {
        
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                CameraMovementManager.Instance.MoveCamera(new Vector3(4.05f, 0, 0),new Vector3(0, 2.36f, -11.227f));
            }
        }
    }
}
