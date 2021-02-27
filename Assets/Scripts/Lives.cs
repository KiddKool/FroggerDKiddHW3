using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    
    public Text FrogLife;

    private void Start()
    {
         
       
        FrogLife.text = PlayerPrefs.GetInt("Lives").ToString();

    }





}
