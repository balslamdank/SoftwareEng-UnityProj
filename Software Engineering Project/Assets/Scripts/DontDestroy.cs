using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Object.DontDestroyOnLoad example.
//
// This script example manages the playing audio. The GameObject with the
// "music" tag is the BackgroundMusic GameObject. The AudioSource has the
// audio attached to the AudioClip.

public class DontDestroy : MonoBehaviour
{
    
	public static void DontDestroyChildOnLoad( GameObject child )
     {
         Transform parentTransform = child.transform;
 
         // If this object doesn't have a parent then its the root transform.
         while ( parentTransform.parent != null )
         {
             // Keep going up the chain.
             parentTransform = parentTransform.parent;
         }
         GameObject.DontDestroyOnLoad(parentTransform.gameObject);
     }
}