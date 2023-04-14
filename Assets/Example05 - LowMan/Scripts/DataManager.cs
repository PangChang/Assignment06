using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayerName;
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
        showPlayerName.text = PlayerName;

    }
    public void ShowName()
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }
}
