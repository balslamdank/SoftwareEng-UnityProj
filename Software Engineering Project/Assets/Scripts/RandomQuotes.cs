using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomQuotes : MonoBehaviour
{
    Text quote;

    public Text[] quoteArr;

    // Start is called before the first frame update
    void Start()
    {
        quote = GetComponent<Text>();
        int randNum = Random.Range(0, quoteArr.Length);
        quote.text = quoteArr[randNum].text;
    }
}
