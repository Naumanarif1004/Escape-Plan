using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Hosting;

public class Healthbar : MonoBehaviour
{
    public Image CurrentHealthPointBar;
    public Text RatioText;
    private float hitpoint = 150;
    private float maxHitpoint = 150;
    public Image damageImage;
    public Color flashColour = new Color(1f, 1f, 1f, 1f);
    public float flashSpeed = 5f;
    bool damaged;
    bool isDead=false;
    Animator anim; 
    bool loadingStarted = false;
    float secondsLeft = 0;
    //ThirdPersonUserControl ThirdPersonUserControlnusercontrol;


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
      void Awake ()
    {
        // Setting up the references.
        anim = GetComponent <Animator> ();
       
       
    }

    void Update()
    {
        // If the player has just been damaged...
        if (damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        // Reset the damaged flag.
        damaged = false;
     
    }

private void Start()

    {
        UpdateHealthbar();
         //StartCoroutine (loadSceneAfterDelay(30));
          
        
    }

    private void UpdateHealthbar()
    {

        float ratio = hitpoint / maxHitpoint;
        CurrentHealthPointBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        RatioText.text = (ratio * 100).ToString("0") + '%';

    }
    
    private void TakeDamage(float damage)
    {
        damaged = true;

        hitpoint -= damage;
        //e;
        if (hitpoint < 0 ) //&& this.timer >= TIME_LIMIT
        {

         hitpoint = 0;
         anim.SetTrigger ("Die");
         StartCoroutine (loadSceneAfterDelay(6));
       
     
        // Tell the animator that the player is dead
         //SceneManager.LoadScene("Try Again");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().BuildIndex + 2);
        }
        UpdateHealthbar();
       
        
    }
     IEnumerator loadSceneAfterDelay(float waitbySecs){

        yield return new WaitForSeconds(waitbySecs);
        SceneManager.LoadScene("Try Again");
    }
 

    private void HealDamage(float heal)
    {
        hitpoint += heal;
        if (hitpoint > maxHitpoint)
        {
            hitpoint = maxHitpoint;
        }
        UpdateHealthbar();
    }

}
