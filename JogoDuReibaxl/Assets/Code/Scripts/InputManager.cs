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
            if (Input.GetKeyDown(KeyCode.D))
            {
                CameraMovementManager.Instance.MoveCamera(new Vector3(0, 90, 0), new Vector3(0, 2.36f, -11.227f));
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                CameraMovementManager.Instance.MoveCamera(new Vector3(0, -90, 0), new Vector3(0, -64.801f, -3.664f));
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                CameraMovementManager.Instance.MoveCamera(new Vector3(4.05f, 0, 0),new Vector3(0, 2.36f, -11.227f));
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                CameraMovementManager.Instance.MoveCamera(new Vector3(4.05f, -26.404f, 0), new Vector3(-0.398f, 2.209f, -10.506f));
            }
            
        
        }
    }
}
