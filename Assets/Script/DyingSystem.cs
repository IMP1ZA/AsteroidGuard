using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingSystem : MonoBehaviour
{
    [SerializeField] private string[] _tag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < _tag.Length; i++)
        {
            if (collision.collider.CompareTag(_tag[i]))
            {
                Destroy(gameObject);
            }
        }
      
    }
}
