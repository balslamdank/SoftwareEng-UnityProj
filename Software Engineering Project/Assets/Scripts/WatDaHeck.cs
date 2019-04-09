using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WatDaHeck : MonoBehaviour
{
	
    public void MuteDaMusic()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("music");

        obj.GetComponent<AudioSource>().mute = !obj.GetComponent<AudioSource>().mute;
    }


}
