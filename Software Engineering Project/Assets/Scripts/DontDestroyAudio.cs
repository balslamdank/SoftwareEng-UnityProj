using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.UI;

public class DontDestroyAudio : MonoBehaviour
{
    void Awake()
	{	
		GameObject toggleobj = GameObject.FindGameObjectWithTag("toggle");
		DontDestroyOnLoad(this.gameObject);
	}
}

