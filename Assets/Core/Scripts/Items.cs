using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField]
    public int itemAmount;
    [SerializeField]
    private ItemScriptableObject Config;

    void Start()
    {
        Debug.Log(Config.itemName);
    }
}
