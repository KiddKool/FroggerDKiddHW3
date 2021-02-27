using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrogDisplay : MonoBehaviour
{
    public string HealthDisplay;
    public GameObject Frog;


    private void Start()
    {
        HealthDisplay = PlayerPrefs.GetInt("Lives").ToString();
    }
}
