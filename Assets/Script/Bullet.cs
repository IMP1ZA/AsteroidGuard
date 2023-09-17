using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _movespeed;
    [SerializeField] private float _destroytime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.right * _movespeed * Time.deltaTime;

        transform.Translate(movement);

        Destroy(gameObject, _destroytime);
    }
}
