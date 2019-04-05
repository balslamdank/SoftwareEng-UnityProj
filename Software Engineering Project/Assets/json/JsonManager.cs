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

    public string getData(string type, string name)
    {
        string filepath = "./" + type;
        if (File.Exists(filepath))
        {
            string json = File.ReadAllText(filepath);
            return json; // using JsonUtility.FromJson< MyClass>(data); to build the data after it is returned. 
        }
        else
        {
            return "";
        }
    }
}
