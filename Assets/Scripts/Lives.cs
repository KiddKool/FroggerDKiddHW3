using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{


    private void Start()
    {
         PlayerPrefs.SetInt("Life",3);
        PlayerPrefs.GetInt("Life");
    }



}
