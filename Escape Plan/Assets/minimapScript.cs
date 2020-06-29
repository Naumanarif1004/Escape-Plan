using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapScript : MonoBehaviour
{
    public Transform ThirdPersonController;
    //an object created for player
    void LateUpdate(){
        //we will update only after the movement of our player ... not before
        Vector3 newPosition = ThirdPersonController.position;

        newPosition.y = transform.position.y;

        transform.position= newPosition;
        /*Quaternion.Euler Returns a rotation that rotates z degrees around the z axis, x degrees
        around the x axis, and y degrees around the y axis; applied in that order.*/
        transform.rotation = Quaternion.Euler(90f,ThirdPersonController.eulerAngles.y,0f);



    }
}
