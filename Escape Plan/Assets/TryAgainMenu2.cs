using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainMenu2 : MonoBehaviour
{
    // Start is called before the first frame update
  public void PlayGame()
    {

        SceneManager.LoadScene("Level2");
    }
    public void ReturnToMainMenu()
    {

        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
