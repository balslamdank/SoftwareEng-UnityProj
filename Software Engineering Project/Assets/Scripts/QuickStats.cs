using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuickStats : MonoBehaviour
{	JSONSaveLoad jsonRead = new JSONSaveLoad();
	public Text hpValue, acValue, strengthValue, dexValue, constValue, intValue, wisValue, charValue;
	
	public void getCurrStats(string filenumb)
	{	
		string path = Application.dataPath + "/PlayerSave" + filenumb + ".json";
		string jsonString = File.ReadAllText(path);
		JSONObject charJson = (JSONObject)JSON.Parse(jsonString);

		hpValue.text = charJson["Current HP"];
		
		strengthValue.text = charJson["Strength"];
		acValue.text = charJson["Armor Class"];
		dexValue.text = charJson["Dexterity"];
		constValue.text = charJson["Constitution"];
		intValue.text = charJson["Intelligence"];
		wisValue.text = charJson["Wisdom"];
		charValue.text = charJson["Charisma"];
       

	}

	void Update()
    {
        string numb = jsonRead.readN();
        getCurrStats(numb);

        
    }
}