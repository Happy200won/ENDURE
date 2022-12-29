using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSound : MonoBehaviour
{
    public AudioClip boulder_drop;
    AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tower")
        {
            //audioSource.clip = boulder_drop;S
            //audioSource.Play();
        }
    }
}
