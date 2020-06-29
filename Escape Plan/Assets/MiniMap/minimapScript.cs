using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapScript : MonoBehaviour
{
    public Transform ThirdPersonController;
    //an object created for player
    void LateUpdate(){
        //we will update only after the movement of our player ... not before
        Vector3 newPosition = ThirdPersonController.position;

        newPosition.y = transform.position.y;

        transform.position= newPosition;
        transform.rotation = Quaternion.Euler(90f,ThirdPersonController.eulerAngles.y,0f);



    }
}
