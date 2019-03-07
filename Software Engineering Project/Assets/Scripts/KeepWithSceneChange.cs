using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Object.DontDestroyOnLoad example.
//
// This script example manages the playing audio. The GameObject with the
// "music" tag is the BackgroundMusic GameObject. The AudioSource has the
// audio attached to the AudioClip.

public class KeepWithSceneChange : MonoBehaviour 

{	

	private static KeepWithSceneChange instance = null;
	public static KeepWithSceneChange Instance
	{
		get {return instance;}
	}

	void Awake()
		{
			if (instance != null && instance != this){
				Destroy(this.gameObject);
				return;
			
			}
		else
		{ 
			instance = this;
		}

		DontDestroyOnLoad(this.gameObject);
		
		}

}