using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tst
{
    public class PlayerManager : MonoBehaviour
    {
        private InputHandler inputHandler;
        private CameraHandler cameraHandler;
        private void Awake()
        {
            inputHandler = GetComponent<InputHandler>();
            cameraHandler = GetComponentInChildren<CameraHandler>();
            Cursor.visible = false;
        }

        private void Update()
        {
            float delta = Time.deltaTime;
            inputHandler.TickInput(delta);
        }

        private void FixedUpdate()
        {
            float delta = Time.fixedDeltaTime;

            if (cameraHandler != null)
            {                
                cameraHandler.HandleCameraRotation(delta, inputHandler.mouseX, inputHandler.mouseY);
            }
        }
    }
}