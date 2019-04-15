using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;
using QuickType;
using Newtonsoft.Json.Linq;

public class TestScript : MonoBehaviour
{
    void Start()
    {
        //string search = this.gameObject.GetComponent<InputField>().text;
        
        string path = Application.dataPath + "/json" + "/" + "magic_items.json";
        string jsonSearchString = File.ReadAllText(path);
        JSONObject searchJSON = (JSONObject)JSON.Parse(jsonSearchString);
        string test = searchJSON.ToString();

        JObject parsed = JObject.Parse(test);

        foreach (var pair in parsed)
        {
            /*if(pair.Key.Contains("Bag"))
            {
                Debug.Log(pair.Value);
            }*/
            Debug.Log(pair.Key + pair.Value);

        }

        //Debug.Log(list[0].ToString());

        //Debug.Log(searchJSON[0].ToString());

       /* string test = searchJSON.ToString();
        var magicItems = MagicItems.FromJson(test);

        Debug.Log(magicItems.MagicItemsMagicItems.TridentOfFishCommand.Content[0]);*/

        //Search through (list? JSON file?)

    }
}

