using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
 {
   // public void win()
    //{  
      //  if (ajLookingAround.position.x == 17.3045f && ajLookingAround.position.y == 0.176f)
        //{
        //    SceneManager.LoadScene("Win");
        //}
    //}

    public void ReturnToMainMenu()
    {

        SceneManager.LoadScene("Menu");
    }
    public void PlayGame()
    {

        SceneManager.LoadScene("Level1");
    }
}