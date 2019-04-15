using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class InputFieldFocusScript : MonoBehaviour
{
    public GameObject mainInputField;
    public GameObject SearchDropDown;
    void Update()
    {
        //mainInputField.GetComponent<InputField>().isFocused == true
        if (mainInputField.GetComponent<InputField>().text != "")
        {
            SearchDropDown.SetActive(true); 
        }

        
        else
        {
            SearchDropDown.SetActive(false);
        }
    } 
}