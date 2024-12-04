using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ShopMenuManager : MonoBehaviour
{
    public TMP_Text currencyText;


    public void Update()
    {
        currencyText.SetText(MainMenuManager.currencyValue.ToString() + " $");

    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
