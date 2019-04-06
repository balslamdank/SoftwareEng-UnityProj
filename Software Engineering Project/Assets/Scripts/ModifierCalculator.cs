using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModifierCalculator : MonoBehaviour
{
    public void Modify()
    {
        foreach (Transform t in this.transform)
        {
            if (t.name == "Modifier" && int.TryParse(this.GetComponent<InputField>().text, out int temp))
            {
                t.GetComponent<Text>().text = ((temp - 10) / 2).ToString();
                break;
            }
        }
    }
}
