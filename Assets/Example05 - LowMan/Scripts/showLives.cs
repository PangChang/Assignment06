using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showLives : MonoBehaviour
{
    public Text showLivesNow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showLivesNow.text = ("Lives You Have Left: ") + PlayerController.playerLives.ToString();
    }
}
