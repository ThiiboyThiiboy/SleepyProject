using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    public GameObject dailyGrid;
    public static int currencyValue;
    public TMP_Text currencyText;

    public void Update()
    {
        currencyText.SetText(currencyValue.ToString() + " $");
     
    }

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

    public void DailyButton()
    {
        dailyGrid.gameObject.SetActive(true);
    }

    public void MONEY()
    {
        currencyValue ++;
    }

    public void CompleteButton()
    {
        //Désactiver le boutton 
        //Rendre le background de la quete Vert
        //Donner des pièces
    }
}
