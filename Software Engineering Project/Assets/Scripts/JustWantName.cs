using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using System.IO;

public class JustWantName : MonoBehaviour
{
    JSONSaveLoad jsonRead = new JSONSaveLoad();
    public Text charName;

    public void getName(string filenumb)
    {
        string path = Application.dataPath + "/PlayerSave" + filenumb + ".json";
        string jsonString = File.ReadAllText(path);
        JSONObject charJson = (JSONObject)JSON.Parse(jsonString);

        charName.text = "Welcome " + charJson["Character Name"] + "!";

    }

    private void Update()
    {
        string numb = jsonRead.readN();
        getName(numb);
    }
}
