using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileDamageController : MonoBehaviour
{
    [SerializeField] private float bombDamage;
    [SerializeField] private MobileHealthController healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
           Move();
        }
    
    }
    void Move()
    {
        healthController.playerHealth = healthController.playerHealth - bombDamage;
        healthController.UpdateHealth();
        SoundManagerScript.PlaySound("hit");
    }
}
