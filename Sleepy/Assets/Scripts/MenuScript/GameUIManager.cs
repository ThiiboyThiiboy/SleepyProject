using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameUIManager : MonoBehaviour
{
    public GameObject Background;

    // Start is called before the first frame update
    void Start()
    {
        Background.SetActive(false);
    }

    public void PauseButton()
    {
        Background.SetActive(true);
        Time.timeScale = 0;
    }

    public void QuitButton()
    {
        Background.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

}
