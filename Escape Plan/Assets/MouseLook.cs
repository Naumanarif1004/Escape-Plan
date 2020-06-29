using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerbody;
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //hide the cursor
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //horizontal movement initialized
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //Vertical movement
        
        xRotation -= mouseY;  //y assign 
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 90 dg rotation

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // Y axis Code
        playerbody.Rotate(Vector3.up * mouseX); //X axis movement
    }
}
