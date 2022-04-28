using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tst
{
    public class CameraHandler : MonoBehaviour
    {
        public float rotationSpeed;
        public Transform pivotAngle;
        private Transform myTransform;       
        private void Awake()
        {            
            myTransform = GetComponent<Transform>();    
        }
        
        public void HandleCameraRotation(float delta, float mouseX, float mouseY)
        {    
            myTransform.localRotation = Quaternion.Euler(mouseY, mouseX, 0);            
        }
    }
}
