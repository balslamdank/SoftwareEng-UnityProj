using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        //string search = this.gameObject.GetComponent<InputField>().text;
        
        string path = Application.dataPath + "/json" + "/" + "magic_items.json";
        string jsonSearchString = File.ReadAllText(path);
        JSONObject searchJSON = (JSONObject)JSON.Parse(jsonSearchString);
        string test = searchJSON.ToString();
        Debug.Log(test);
        Debug.Log(test["Amulet of Health"]);



        //Search through (list? JSON file?)

    }
}

