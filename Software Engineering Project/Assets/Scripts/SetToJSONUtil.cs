using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetToJSONUtil : MonoBehaviour
{	
	
	JSONObject buttID = new JSONObject();

	public void findN()
	{	string tagNumb;
		string path = Application.dataPath + "/jsonUtility.json";
		tagNumb = gameObject.tag;
		buttID.Add("ButtonID", tagNumb);
		File.WriteAllText(path, buttID.ToString());
		
	
	}
}