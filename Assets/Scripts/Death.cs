using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public MobileHealthController health;

    // Update is called once per frame
    void Update()
    {
        if(health.playerHealth<0.1)
        {
            Application.LoadLevel("DeathScene");
        }
    }
}
