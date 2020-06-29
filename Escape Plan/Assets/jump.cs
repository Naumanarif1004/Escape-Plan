using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public AudioSource jumpUp;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpUp.Play();
        }
    }
}
