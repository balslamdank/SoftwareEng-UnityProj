using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadTitle : MonoBehaviour
{
    public string str;

    public void Start()
    {
        SceneManager.LoadScene(str);
    }
}