using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileHealthController : MonoBehaviour
{
    public float playerHealth;
    [SerializeField] private Text healthText;

    public void UpdateHealth()
    {
        healthText.text = playerHealth.ToString("0");
    }
    void Update()
    {
        if (playerHealth < 0)
        {
            Application.LoadLevel("Untitled");
        }
    }
}
