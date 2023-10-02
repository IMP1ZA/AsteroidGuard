using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.0f;
    private Manager _manager;
    // Start is called before the first frame update
    void Start()
    {
        _manager = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet")) 
        {
            _manager.GetScore();
            Destroy(gameObject);       
        }
    }
}
