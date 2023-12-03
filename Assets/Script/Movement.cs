using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Animator _anim;
    private Rigidbody _rb;

    void Start()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);
        _rb.AddForce(movement.normalized * _moveSpeed, ForceMode.Force);

        _anim.SetFloat("UpAndDown", verticalInput);
    }
}



