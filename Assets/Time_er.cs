using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Time_er : MonoBehaviour
{
    public Text text;
    public float time;
    // Start is called before the first frame 
    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        text.text = "Time : " + time.ToString("F2");
    }
}
