using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _movespeed;
    [SerializeField] private float _destroytime;
    private Rigidbody rb;
    private Vector3 _lastVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Move();
        Destroy(gameObject, _destroytime);
    }

    // Update is called once per frame
    void Update()
    {
        _lastVelocity = rb.velocity;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = _lastVelocity.magnitude;
        var direction = Vector3.Reflect(_lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);

        if (collision.collider.CompareTag("Meteor")) 
        {
            Destroy(gameObject);
        }
    }

    void Move() 
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; 

        Vector3 direction = (mousePosition - transform.position).normalized;

        rb.AddForce(direction * _movespeed, ForceMode.Impulse);
    }
}
