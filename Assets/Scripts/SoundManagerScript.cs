using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
       public static AudioClip playerHitSound, Sus, Jos;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("Hit");
        Sus = Resources.Load<AudioClip>("Sus");
        Jos = Resources.Load<AudioClip>("Jos");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "hit":
                audioSrc.PlayOneShot(playerHitSound);
                break;
            case "sus":
                audioSrc.PlayOneShot(Sus);
                break;
            case "jos":
                audioSrc.PlayOneShot(Jos);
                break;
        }
     
    }
}
