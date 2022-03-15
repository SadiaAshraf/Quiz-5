using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalMovement;
    private int Speed = 50;
    
 

   
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * Speed * horizontalMovement);
    }
}
