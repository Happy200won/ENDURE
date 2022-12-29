using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    public int Hp= 50;
    public Text text;
    public GameObject ob1;
    public GameObject ob2;
    private void Awake()
    {
        ob1.SetActive(false);
        ob2.SetActive(false);
        text.text = "Tower HP : " + Hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp==0)
        {
            ob1.SetActive(true);
            ob2.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tower")
        {
            text.text = "Tower HP : " + Hp.ToString();
            Hp--;
        }
    }
}
