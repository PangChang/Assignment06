using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject playerPrefab;
    

    // Start is called before the first frame update


    void Update()
    {
        if (PlayerController.playerLives == 0)
        {
            SceneManager.LoadScene("Exit");
        }
    }

}
