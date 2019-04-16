using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownHandler : MonoBehaviour
{
    public GameObject pathObj;
    public GameObject pathObj2;

    public void ChangePath()
    {
        switch (this.gameObject.GetComponent<Dropdown>().options[this.gameObject.GetComponent<Dropdown>().value].text)
        {
            case "Magic Items":
                pathObj.GetComponent<Searching>().fileSearchName = "magic_items";
                pathObj2.GetComponent<DisplayDetails>().fileSearchName = "magic_items";
                break;

            case "Spells":
                pathObj.GetComponent<Searching>().fileSearchName = "spells";
                pathObj2.GetComponent<DisplayDetails>().fileSearchName = "spells";
                break;

            case "Items":
                pathObj.GetComponent<Searching>().fileSearchName = "items";
                pathObj2.GetComponent<DisplayDetails>().fileSearchName = "items";
                break;
        }
    }
}
