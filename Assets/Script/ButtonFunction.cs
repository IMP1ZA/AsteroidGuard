using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    [SerializeField] private string _mainmenu;

    public void Restart() 
    {
        Scene scene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(scene.name);
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene(_mainmenu);
    }
    public void QuitGame() 
    {
        Application.Quit();
    }

}
