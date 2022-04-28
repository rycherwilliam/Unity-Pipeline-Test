using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Tst
{
    public class InputHandler : MonoBehaviour
    {       
        public float mouseX;
        public float mouseY;   

        PlayerControls inputActions;      
        Vector2 cameraInput;


        public void OnEnable()
        {
            if (inputActions == null)
            {
                inputActions = new PlayerControls();
                inputActions.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();
            }

            inputActions.Enable();
        }

        private void OnDisable()
        {
            inputActions.Disable();
        }

        public void TickInput(float delta)
        {
            MoveInput();
        }

        private void MoveInput()
        {
            mouseX += cameraInput.x;
            mouseY -= cameraInput.y;
        }
    }
}