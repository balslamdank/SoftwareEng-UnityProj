using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public object[] GetData(string type)
    {
        string filepath = "./" + type;
        if (File.Exists(filepath))
        {
            string json = File.ReadAllText(filepath);
            return this.FormatJson(json, type); // remember to cast the json to the type desired when you get it
        }
        else
        {
            return this.FormatJson("", "");
        }
    }

    public object[] FormatJson(string json, string type) // recall to cast the json to the type desired when you get it
    {
        // need a way to deal with the tables that exist in some things
        if (type == "spells" || type == "magic_items" || type == "items")
        {
            return JsonUtility.FromJson<ContentOnlyItem[]>(json);
        }
        else
        {
            return null;
        }
    }
}