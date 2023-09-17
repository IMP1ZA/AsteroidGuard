using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _horizontalInput = Input.GetAxis("Horizontal");
        float _verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(_horizontalInput, _verticalInput, 0.0f) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }
}
