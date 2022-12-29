using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MonsterDie : MonoBehaviour
{
    public GameObject skill;
    public GameObject skill2;
    public GameObject effect2;
    public GameObject effect;
    static GameObject p;
    public AudioClip boulder_drop;
    AudioSource audiosource;
    public static int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "die")
        {
            p=Instantiate(skill, effect.transform);
            SoundManager.Instance.audiosource.Play();
            Destroy(p, 1.5f);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag=="ok")
        {
            Destroy(gameObject);
            Instantiate(skill2, effect2.transform);
            SoundManager.Instance.audiosource.Play();
        }
    }
}
