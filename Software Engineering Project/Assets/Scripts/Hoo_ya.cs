using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hoo_ya : MonoBehaviour
{
    Scene currScene;
	public GameObject statsPanel;
    

	void Update () {
        currScene = SceneManager.GetActiveScene();
        if (currScene.name == "TitleScreen")
        {
            ;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                statsPanel.gameObject.SetActive(!statsPanel.gameObject.activeSelf);
               
            }
        }

	}
}