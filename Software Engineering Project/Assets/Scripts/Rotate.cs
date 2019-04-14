using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    float rotatespeed;
    float seconds;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rotatespeed = Random.Range(0.5f, 1.5f);
        seconds = Random.Range(5.0f, 10.0f);
        Debug.Log(rotatespeed);
        Debug.Log(seconds);

    }

    // Update is called once per frame
    void Update()
    {
        if (seconds >= timer)
        {
            this.transform.Rotate(Vector3.forward, rotatespeed * (seconds - timer));
            this.transform.Rotate(Vector3.up, rotatespeed * (seconds - timer));
            //Debug.Log(Time.deltaTime);
            timer += Time.deltaTime;
        }
        
        //Debug.Log(timer);

    }

}
