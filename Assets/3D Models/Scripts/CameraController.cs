using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private Vector3 initialPosition;
   [SerializeField] private Vector3 maxPosition;
   [SerializeField] [Range(0,1)]private float progress;

    private void Awake() {
        transform.localPosition = initialPosition;
       
   }
        
     private void update() {
            
            transform.localPosition = Vector3.Lerp(initialPosition, maxPosition, progress);
        }
    
}
