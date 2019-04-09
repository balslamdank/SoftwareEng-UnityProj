using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using UnityEngine.UI;

public class GetSetCampaignName : MonoBehaviour
{
    Text campaignText;
	public string campaignNumber;
    public string fileCampaignName;

    // Start is called before the first frame update
    void Start()
    {   Debug.Log("Path : " + Application.dataPath);
		campaignNumber = gameObject.tag;
		campaignText = GetComponent<Text>();
		string path = Application.dataPath + "/PlayerSave" + campaignNumber + ".json";
		

		string jsonString = File.ReadAllText(path);
		JSONObject charJson = (JSONObject)JSON.Parse(jsonString);

		fileCampaignName = charJson["Character Name"];

		if(fileCampaignName == "")
		{
			campaignText.text = "New Campaign";
		}
		else 
		{
			campaignText.text = fileCampaignName;
		}
    }
}

