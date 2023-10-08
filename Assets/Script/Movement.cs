using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
         float verticalMovement = Input.GetAxis("Vertical");
         float horizontalMovement = Input.GetAxis("Horizontal");
         
         Vector3 movement = new Vector3(horizontalMovement, verticalMovement, 0) * _moveSpeed * Time.deltaTime;

         transform.Translate(movement);
    }
}



