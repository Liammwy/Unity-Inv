using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    [SerializeField]
    public int itemAmount;
    [SerializeField]
    public ItemScriptableObject Config;


    private void Start()
    {
        itemAmount = 0;
    }
}
