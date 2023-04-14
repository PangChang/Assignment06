using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Example05 - LowMan");
    }

    public void FinishGame()
    {
        SceneManager.LoadScene("Exit");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
