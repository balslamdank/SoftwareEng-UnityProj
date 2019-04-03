using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JSONSaveLoad : MonoBehaviour
{	public InputField campaignName;

	
	public InputField playerTitle;
	public InputField playerRace;
	public InputField playerClass;
	public InputField level;
	public InputField HP;
	public string numb;
	

	
	// Save updated data to JSON file
	void Save(string filenumb) 
	{  
		JSONObject charInfo = new JSONObject();
		charInfo.Add("Campaign Name", campaignName.text);
		charInfo.Add("Title", playerTitle.text);
		charInfo.Add("Race", playerRace.text);
		charInfo.Add("Class", playerClass.text);
		

		charInfo.Add("Level", level.text);
		charInfo.Add("HP", HP.text);

		Debug.Log(charInfo.ToString());

		string path = Application.dataPath + "/PlayerSave" + filenumb + ".json";

		File.WriteAllText(path, charInfo.ToString());
	}

	// Load data to game
	public string readN()
	{
			string pathB = Application.dataPath + "/jsonUtility.json";
			string jsonString = File.ReadAllText(pathB);
			JSONObject charJson = (JSONObject)JSON.Parse(jsonString);
			numb = charJson["ButtonID"];
			return numb;
	}

	void Load(string filenumb)
	{	
		string path = Application.dataPath + "/PlayerSave" + filenumb + ".json";

		string jsonString = File.ReadAllText(path);
		JSONObject charJson = (JSONObject)JSON.Parse(jsonString);

		campaignName.text = charJson["Campaign Name"];
		playerTitle.text = charJson["Title"];
		playerRace.text = charJson["Race"];
		playerClass.text = charJson["Class"];
		level.text = charJson["Level"];
		HP.text = charJson["HP"];

	}
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("Path : " + Application.dataPath);

        if(SceneManager.GetActiveScene().name == "Main"){
			string numb = readN();
			Load(numb);
		}
    }

	void clearAll()
	
	{

		playerTitle.text = "";
		campaignName.text = "";
		playerTitle.text = "";
		playerRace.text = "";
		playerClass.text = "";
		level.text = "";
		HP.text = "";

	
		
	}
    // Update is called once per frame
    public void getSelection(string mySelection)
    {	string selectnumb = readN();
        if(mySelection == "save"){ 
		Save(selectnumb);
		Debug.Log("Working Save");
		}
		if(mySelection == "load"){
		Load(selectnumb);
		Debug.Log("Working Load");}
		if(mySelection == "clear"){
		clearAll();
		}
    }
}
