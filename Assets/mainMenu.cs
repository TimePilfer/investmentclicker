using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

    public void clickExit()
    {
        Application.Quit();
    }

    public void clickStartNewGame()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
