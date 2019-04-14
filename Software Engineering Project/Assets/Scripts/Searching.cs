using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

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

        string path = Application.dataPath + "/json" + "/" + fileSearchName;
		string jsonSearchString = File.ReadAllText(path);
		JSONObject searchJSON = (JSONObject)JSON.Parse(jsonSearchString);

		string[] searchResults = searchJSON[search];

		foreach( string query in searchJSON)
		{
			if (query.contains(search))
			{
				//Return JSON array 
			}
		}

	

        //Search through (list? JSON file?)

    }
}
