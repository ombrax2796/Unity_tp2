using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //Variable
    public string SampleScene;

    public void StartGame()
    {

        SceneManager.LoadScene(SampleScene);

    }

    public void QuitGame()
    {

        Application.Quit();

    }

}
