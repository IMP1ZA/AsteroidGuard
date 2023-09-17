using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _shootPosition;
    [SerializeField] private float _cooldown;

    private bool _canShoot  = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && _canShoot) 
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot() 
    {
        _canShoot = false;

        Instantiate(_bullet, _shootPosition.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(_cooldown);

        _canShoot = true;
    }
}
