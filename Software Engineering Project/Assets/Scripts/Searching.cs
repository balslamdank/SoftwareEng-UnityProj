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
	public string fileSearchName;
    public GameObject buttons;
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

        //string path = Application.dataPath + "/json" + "/" + fileSearchName + ".json";
        string path = Application.dataPath + "/" + fileSearchName + ".json";
        string jsonSearchString = File.ReadAllText(path);
        JSONObject searchJSON = (JSONObject)JSON.Parse(jsonSearchString);
        string test = searchJSON.ToString();
        List<List<string>> myList = new List<List<string>>();

        JObject parsed = JObject.Parse(test);
        int i = 0;

        foreach (var pair in parsed)
        {
            if(pair.Key.ToLower().Contains(search.ToLower()))
            {
                Debug.Log(pair.Key);
                myList.Add(new List<string> {pair.Key, pair.Value.ToString()});
            }
        }

        foreach(Transform child in buttons.transform)
        {
            if (i < myList.Count)
            {
                child.GetChild(0).GetComponent<Text>().text = myList[i][0];
                i++;
            }

            else
            {
                child.GetChild(0).GetComponent<Text>().text = "";
            }
        }

        yield return null;

        //Search through (list? JSON file?)

    }
    
}
