using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ShopCell : MonoBehaviour
{
    public Cosmetics[] hatItemSO;
    public ShopTemplate[] shopButtons;
    public GameObject[] hatButton;
    public Button[] hatButtonInte;
    public TMP_Text currencyText;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < hatItemSO.Length; i++)
        {
            hatButton[i].SetActive(true);
        }

        for (int i = 0; i < hatItemSO.Length; i++)
        {
            shopButtons[i].price.text = hatItemSO[i].price.ToString() + "$";
            shopButtons[i].sprite.image.sprite = hatItemSO[i].sprite;
            shopButtons[i].buyed = hatItemSO[i].buyed;
        }
        CheckPurchaseable();
    }

    public void CheckPurchaseable()
    {
        for (int i = 0; i < hatItemSO.Length; i++)
        {
            if (MainMenuManager.currencyValue >= hatItemSO[i].price)
            {
                hatButtonInte[i].interactable = true;

            }
            else
            {
                hatButtonInte[i].interactable = false;
            }

        }
    }

    public void PurchaseItem(int btnNO)
    {
        if (MainMenuManager.currencyValue >= hatItemSO[btnNO].price)
        {
            MainMenuManager.currencyValue = MainMenuManager.currencyValue - hatItemSO[btnNO].price;
            currencyText.SetText(MainMenuManager.currencyValue.ToString() + " $");
            CheckPurchaseable();
            //UnlockItem

        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
