using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class InputFieldFocusScript : MonoBehaviour
{
    public GameObject mainInputField;
    public GameObject SearchDropDown;
    void Update()
    {
        //If the input field is focused, change its color to green.
        if (mainInputField.GetComponent<InputField>().isFocused == true && mainInputField.GetComponent<InputField>().text != "")
        {
            SearchDropDown.SetActive(true); 
        }

        else
        {
            SearchDropDown.SetActive(false);
        }
    } 
}