using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
<<<<<<< HEAD

public class JSONSaveLoad : MonoBehaviour
{	
=======
using UnityEngine.UI;

public class JSONSaveLoad : MonoBehaviour
{	public InputField InputFieldMyVal;

>>>>>>> general_not_master
	public string campaignName;
	public string playerRole;
	public string playerRace;
	public string playerClass;
	public string items;
	public string spells;
	
	public string itemsList;
	public string spellList;
	
	// Save updated data to JSON file
	void Save() 
	{
		JSONObject charInfo = new JSONObject();
		charInfo.Add("Campaign Name", campaignName);
		charInfo.Add("Title", playerRole);
		charInfo.Add("Race", playerRace);
		charInfo.Add("Class", playerClass);
		

		charInfo.Add("Items", itemsList);
		charInfo.Add("Spells", spellList);

		Debug.Log(charInfo.ToString());

		//string path = Application.persistentDataPath + "/PlayerSave.json";
<<<<<<< HEAD
		string path = "C:/Users/Balsam/Documents/databaseproj/SoftwareEng-UnityProj/Software Engineering Project" + "/PlayerSave.json";
=======
		string path = Application.persistentDataPath + "/PlayerSave.json";
>>>>>>> general_not_master

		File.WriteAllText(path, charInfo.ToString());
	}

	// Load data to game
	void Load()
	{
		//string path = Application.persistentDataPath + "/PlayerSave.json";
<<<<<<< HEAD
		string path = "C:/Users/Balsam/Documents/databaseproj/SoftwareEng-UnityProj/Software Engineering Project" + "/PlayerSave.json";
=======
		string path = Application.persistentDataPath + "/PlayerSave.json";
>>>>>>> general_not_master

		string jsonString = File.ReadAllText(path);
		JSONObject charJson = (JSONObject)JSON.Parse(jsonString);

		campaignName = charJson["Campaign Name"];
		playerRole = charJson["Title"];
		playerRace = charJson["Race"];
		playerClass = charJson["Class"];
		itemsList = charJson["Items"];
		spellList = charJson["Spells"];
<<<<<<< HEAD
=======
		InputFieldMyVal.text = charJson["Campaign Name"];
>>>>>>> general_not_master

	}
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }

    // Update is called once per frame
    public void getSelection(string mySelection)
    {
        if(mySelection == "save"){ 
		Save();
		Debug.Log("Working Save");
		}
		if(mySelection == "load"){
		Load();
		Debug.Log("Working Load");}
    }
}
