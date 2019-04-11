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

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			RectTransform theRectTransform;
 
			theRectTransform = transform as RectTransform; // Cast it to RectTransform
			theRectTransform.SetAsLastSibling(); // Make the panel show on top.
			//transform.SetAsLastSibling ();

			statsPanel.gameObject.SetActive(!statsPanel.gameObject.activeSelf);
		}
	}
}