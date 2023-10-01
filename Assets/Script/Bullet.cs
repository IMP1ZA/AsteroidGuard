using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _movespeed;
    [SerializeField] private float _destroytime;

    [SerializeField] private int _destroyTarget;
    private int _destroyCount;

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

        if (_destroyCount == _destroyTarget)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var speed = _lastVelocity.magnitude;
        var direction = Vector3.Reflect(_lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
        float collisionAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion newRotation = Quaternion.Euler(new Vector3(0, 0, collisionAngle));
        transform.rotation = newRotation;
        if (collision.collider.CompareTag("Meteor"))
        {
            _destroyCount++;
        }
    }

    void Move()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        Vector3 direction = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        rb.AddForce(direction * _movespeed, ForceMode.Impulse);
    }
}
