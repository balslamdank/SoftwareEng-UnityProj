using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SubMenuCollapse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject menuReference;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {

    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        menuReference.SetActive(false);
    }
}
