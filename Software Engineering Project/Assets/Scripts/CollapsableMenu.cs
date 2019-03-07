using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class CollapsableMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject menuReference;
    public GameObject groupReference;
    public GameObject groupReference2;


    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        menuReference.SetActive(true);
        groupReference.SetActive(false);
        groupReference2.SetActive(true);
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        try
        {
            if (pointerEventData.pointerCurrentRaycast.gameObject.name != "unique")
            {
                menuReference.SetActive(false);
                groupReference2.SetActive(false);
            }
        }

        catch(Exception e)
        {

        }
    }
}
