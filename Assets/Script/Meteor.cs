using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private string _bullet;
    [SerializeField] private string _wall;
    [SerializeField] private string _player;
    [SerializeField] private AudioClip _ac;
    private ScoreManager _scoreManager;
    private LifeManager _lifeManager;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
        _lifeManager = FindObjectOfType<LifeManager>();
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
        
        if (collision.collider.CompareTag(_bullet))
        {
            _scoreManager.GetScore();
            Destroy(gameObject);
        }

        if (collision.collider.CompareTag(_player))
        {
            Destroy(gameObject);
        }

        if (collision.collider.CompareTag(_wall)) 
        {
            _lifeManager.LifeDecrease();
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(_ac, transform.position);
    }
}
