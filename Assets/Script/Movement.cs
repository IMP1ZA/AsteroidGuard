using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
         float _verticalMovement = Input.GetAxis("Vertical");
         float _horizontalMovement = Input.GetAxis("Horizontal");
         
         Vector3 movement = new Vector3(_horizontalMovement, _verticalMovement, 0) * moveSpeed * Time.deltaTime;

         transform.Translate(movement);
    }
}



