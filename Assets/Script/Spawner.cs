using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _meteor;
    [SerializeField] private float _minCooldown;
    [SerializeField] private float _maxCooldown;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn() 
    {
        while (true) 
        {
            float randomCooldown = Random.Range(_minCooldown, _maxCooldown);

            yield return new WaitForSeconds(randomCooldown);

            Instantiate(_meteor, transform.position, Quaternion.identity);              
        }
    }
}
