using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class EnemyHealth : MonoBehaviour
{

    public UnityEvent OnDeath;
    public UnityEvent OnHit;
    // public AudioClip deathClip;

    public float enemyHealth = 100f;


    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }
  

    public void TakeDamage(float amount)
    {
        enemyHealth -= amount;
        //EnemyAudio.Play();
        if (enemyHealth <= 0f)
        {
            Die();
        }
        else
        {
            OnHit.Invoke();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        OnDeath.Invoke();
    }

}
