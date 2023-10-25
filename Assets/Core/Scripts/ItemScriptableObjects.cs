using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item", menuName = "Items/Items SO")]
public class ItemScriptableObject : ScriptableObject
{
    private bool x;

    // Data that we want EVERY item to have
    public string itemName;
    public string itemDescription;
    public int MAX_SIZE;
    public Sprite itemImage;
    public GameObject itemObject;
}
