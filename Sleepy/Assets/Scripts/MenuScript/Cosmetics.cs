using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCosmetic", menuName = "ScriptableObjects/Cosmetic", order = 1)]
public class Cosmetics : ScriptableObject
{
    public GameObject mesh;
    public int price;
    public Sprite sprite;
    public bool buyed;

}
    
