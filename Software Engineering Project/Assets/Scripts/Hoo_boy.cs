using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Hoo_boy : MonoBehaviour
{	
	public GameObject statsPanel;
	public GameObject[] panelobjs;
    
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			
			
			
			foreach(GameObject panelobj in panelobjs) {
				Debug.Log("Tagged Obejcts:" + gameObject.name);
				}

			
			
			statsPanel.gameObject.SetActive(!statsPanel.gameObject.activeSelf);
           
		}
	}
}