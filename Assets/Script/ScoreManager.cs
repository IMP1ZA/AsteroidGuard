using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _winScene;
    [SerializeField] private int _scoreTarget;
    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score: " + Score;

        if(Score >= _scoreTarget)  
        {
            Time.timeScale = 0f;
            _winScene.SetActive(true);
        }
    }

    public int GetScore() 
    {
        Score++;
        return Score;    
    }


}
