using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using System.IO;
using Newtonsoft.Json.Linq;

public class Searching : MonoBehaviour
{
    private IEnumerator coroutine;
    private bool isRunning = false;
	[SerializeField] string fileSearchName;
    public void FireOffSearch()
    {
        //Cancel other LetterFinds if they exist
        if(isRunning == true)
        {
            isRunning = false;
            StopCoroutine(coroutine);
        }

        //Start new LetterFind
        coroutine = LetterFind();
        StartCoroutine(coroutine);
    }

    IEnumerator LetterFind()
    {
        isRunning = true;
        string search = this.gameObject.GetComponent<InputField>().text;

        string path = Application.dataPath + "/json" + "/" + "magic_items.json";
        string jsonSearchString = File.ReadAllText(path);
        JSONObject searchJSON = (JSONObject)JSON.Parse(jsonSearchString);
        string test = searchJSON.ToString();

        JObject parsed = JObject.Parse(test);

        foreach (var pair in parsed)
        {
            if(pair.Key.ToLower().Contains(search.ToLower()))
            {
                Debug.Log(pair.Key);
            }

        }

        yield return null;

        //Search through (list? JSON file?)

    }
    
}
