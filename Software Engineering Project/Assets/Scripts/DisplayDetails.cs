using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using TMPro;

public class DisplayDetails : MonoBehaviour
{
    public string selectedItem = "";
    public Button butt1, butt2, butt3, butt4;
    public string fileSearchName;
    public Text contentDetails;
    public TextMeshProUGUI keyValue;
    



    public void SetSelection(Button buttype )
    {
        selectedItem = buttype.GetComponentInChildren<Text>().text;

    }


    
    void whoKnows(string panelContent)
    {
        string test2 = "";
        string path = Application.dataPath + "/json" + "/" + fileSearchName + ".json";
        string jsonSearchString = File.ReadAllText(path);
        JSONObject searchJSON = (JSONObject)JSON.Parse(jsonSearchString);
        string test = searchJSON.ToString();
        using (var stringReader = new StringReader(test))

        using (var stringWriter = new StringWriter())
        {
            var jsonReader = new JsonTextReader(stringReader);
            var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
            jsonWriter.WriteToken(jsonReader);
            test2 = stringWriter.ToString();
        }
        JObject parsed = JObject.Parse(test2);

        foreach (var pair in parsed)
        {
            if (pair.Key.ToLower().Contains(panelContent.ToLower()))
            {
                Debug.Log(pair.Key);
                Debug.Log("Content Info:" + pair.Value.ToString());
                string resultingText = pair.Value.ToString();
                resultingText = resultingText.Replace("{", "");
                resultingText = resultingText.Replace("}", "");
                contentDetails.text = resultingText;
                

         

            }
        }

       


   }

    void Start()
    {
        butt1.onClick.AddListener(() => SetSelection(butt1));
        butt2.onClick.AddListener(() => SetSelection(butt2));
        butt3.onClick.AddListener(() => SetSelection(butt3));
        butt4.onClick.AddListener(() => SetSelection(butt4));

    }



    void Update()
    {
        whoKnows(selectedItem);
        Debug.Log("Selected Item:" + selectedItem);
        keyValue.SetText(selectedItem);
    }
        
    
}

