using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    [SerializeField] private Text _lifeText;
    [SerializeField] private GameObject _loseScene;
    [SerializeField] private int _life;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        _lifeText.text = "Life: " + _life;

        if (_life <= 0)
        {
            Time.timeScale = 0f;
            _loseScene.SetActive(true);
        }
    }

    public int LifeDecrease()
    {
        _life--;
        return _life;
    }


}
