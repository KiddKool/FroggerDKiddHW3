using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public static string Playername;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StorePlayer()
    {
        Playername = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = Playername;
        PlayerPrefs.SetString("Playername",inputField.GetComponent<Text>().text);
        PlayerPrefs.GetString("Playername");

    }
}
