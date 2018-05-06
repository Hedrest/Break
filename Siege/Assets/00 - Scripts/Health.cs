using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class Health : MonoBehaviour {

    public UnityEvent OnDeath;
    public UnityEvent OnHit;
    public  Image healthUi;
    // public AudioClip deathClip;
    public  float maxHealth = 150f;
    public  float currentHealth = 0f;


    public void Start()
    {
        currentHealth = maxHealth;
    }
    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }


    


    public void TakeDamage (float amount)
    {
        currentHealth -= amount;
      
        healthUi.fillAmount = currentHealth / maxHealth;
       
        
        //playerAudio.Play();
        if (currentHealth <= 0f)
        {
            Die();
        }
        else
        {
            OnHit.Invoke();
        }
    }


    void Die ()
    {
        Destroy(gameObject);
        OnDeath.Invoke();
    }

}
