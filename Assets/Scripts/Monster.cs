using System.Collections;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public GameObject MS;
    public GameObject S;
    public AudioClip monster;
    AudioSource audiosource;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(spawn());
    }
    float random;
    IEnumerator spawn()
    {
        while (true)
        {
            random = Random.Range(7.0f, 10.0f);
            Debug.Log(random);
            Instantiate(MS, pos, Quaternion.identity);
            yield return new WaitForSeconds(random);
        }
    }
    // Update is called once per frame
    void Update()
    {
        pos = transform.position + new Vector3(0, 1, 0);
    }
}
