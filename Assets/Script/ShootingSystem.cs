using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _shootPosition;
    [SerializeField] private float _cooldown;
    [SerializeField] private AudioSource _as;

    private bool _canShoot  = true;

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

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _as.Play();
        Instantiate(_bullet, _shootPosition.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(_cooldown);
        
        _canShoot = true;
    }
}
