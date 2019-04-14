using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

public class Searching : MonoBehaviour
{
    private IEnumerator coroutine;
    private bool isRunning = false;

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
        
        //Search through (list? JSON file?)

    }
}
