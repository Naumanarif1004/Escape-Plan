using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchToWin2 : MonoBehaviour
{
  void OnTriggerEnter(Collider other){
      SceneManager.LoadScene("Win2");
  }
}
