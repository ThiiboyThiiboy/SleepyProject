using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "Cosmetics", menuName = "ScriptableObjects/Cosmetic", order = 1)]
public class ShopCell : MonoBehaviour
{
    public Cosmetics thisCosmetic;
    public TextMeshProUGUI thisPrice;

    // Start is called before the first frame update
    void Start()
    {
        thisPrice.text = thisCosmetic.price.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
