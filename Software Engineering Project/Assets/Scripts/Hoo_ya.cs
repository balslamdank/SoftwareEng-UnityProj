using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hoo_ya : MonoBehaviour
{	
	public GameObject statsPanel;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			statsPanel.gameObject.SetActive(!statsPanel.gameObject.activeSelf);
		}
	}
}