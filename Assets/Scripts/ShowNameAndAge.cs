using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowNameAndAge : MonoBehaviour
{
    TextMeshProUGUI text;
    string playerName;
    int playerAge;
    // Start is called before the first frame update
    void Start()
    {
        playerName = PlayerPrefs.GetString("ThisPlayer", "playerName");
        playerAge = PlayerPrefs.GetInt("ThisAge");
        text = GetComponent<TextMeshProUGUI>();

        text.SetText("Hi " + playerName + " your age is " + playerAge.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
