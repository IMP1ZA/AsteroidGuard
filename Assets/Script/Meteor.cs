using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private string _tag;
    private UIManager _manager;
    // Start is called before the first frame update
    void Start()
    {
        _manager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet")) 
        {
            _manager.GetScore();
            Destroy(gameObject);       
        }
    }
}
