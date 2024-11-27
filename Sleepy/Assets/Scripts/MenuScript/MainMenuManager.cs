using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShopButton()
    {
        SceneManager.LoadScene("ShopScene");
    }

    public void LockerButton()
    {
        SceneManager.LoadScene("LockerScene");
    }
}
