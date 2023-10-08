using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private string _tag;
    private UIManager _manager;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _manager = FindObjectOfType<UIManager>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(-_moveSpeed, 0, 0);

        _rb.velocity = movement;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(_tag)) 
        {
            _manager.GetScore();
            Destroy(gameObject);       
        }
    }
}
