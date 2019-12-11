using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public MobileHealthController health;
    void Update()
    {
        if(health.playerHealth<0.1)
        {
            SoundManagerScript.PlaySound("hit");
            Application.LoadLevel("DeathScene");
        }
    }
}
