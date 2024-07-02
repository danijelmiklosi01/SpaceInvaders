using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerPrefsText : MonoBehaviour
{
    public string name;


    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(name) + "";   
    }
}
