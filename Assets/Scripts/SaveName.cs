using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveName : MonoBehaviour
{
    public InputField playerHandle;
    public InputField playerAge;
    public string playerName;
    public int myAge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SavePlayerName()
    {
        playerName = playerHandle.text;
        PlayerPrefs.SetString("ThisPlayer", playerName);
        
        
    }
    public void SaveAge()
    {
        myAge = int.Parse(playerAge.text);
        PlayerPrefs.SetInt("ThisAge", myAge);
    }
    
}
