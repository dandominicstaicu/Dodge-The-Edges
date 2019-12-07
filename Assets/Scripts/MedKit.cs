using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
    [SerializeField] private float vDamage;
    [SerializeField] private MobileHealthController healthController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
        }
    }
    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - vDamage;
        healthController.UpdateHealth();
        this.gameObject.SetActive(false);
    }
}
