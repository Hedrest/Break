using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public GameObject pickupEffect;
    public float bonusHealth = 2f;
    public float duration = 10f;

      void OnTriggerEnter(Collider other)
     {
         if (other.CompareTag("Player"))
         {
             StartCoroutine (Pickup(other));
         }
     }

    IEnumerator Pickup(Collider player)
     {


         Instantiate(pickupEffect, transform.position, transform.rotation);
         Health stats = player.GetComponent<Health>();
         stats.currentHealth += bonusHealth;
        stats.healthUi.fillAmount = stats.currentHealth;
       


         GetComponent<MeshRenderer>().enabled = false;
         GetComponent<SphereCollider>().enabled = false;
        yield return null;
          //yield return new WaitForSeconds(duration);

        // stats.currentHealth /= multiplier;
         Destroy(gameObject);
     }
}
