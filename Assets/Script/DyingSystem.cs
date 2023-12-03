using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DyingSystem : MonoBehaviour
{
    [SerializeField] private string[] _tag;
    [SerializeField] private GameObject _LoseScene;
    [SerializeField] private AudioClip _ac;
    private LifeManager _lifeManager;
    // Start is called before the first frame update
    void Start()
    {
        _lifeManager = FindObjectOfType<LifeManager>();
    }


    void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < _tag.Length; i++)
        {
            if (collision.collider.CompareTag(_tag[i]))
            {
                _lifeManager.LifeDecrease();
            }
        }
      
    }

    void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(_ac, transform.position);
    }
}
