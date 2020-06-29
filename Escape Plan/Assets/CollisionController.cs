using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public HealthBarController healthBar;
    void onCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "LargeFlames")
        {
            if(healthBar)
            {
                healthBar.OnTakeDamage(10);
            }
        }

    }
}
