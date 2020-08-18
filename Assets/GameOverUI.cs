using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOverUI : MonoBehaviour
{
    
    public void RestartGame()
    {
        int CurrentIindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentIindex);
    }

    // Update is called once per frame
    public void CloseGame()
    {
        Application.Quit();
    }
}
