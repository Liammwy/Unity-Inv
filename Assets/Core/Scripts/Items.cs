using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Items : MonoBehaviour
{
    [SerializeField]
    public int itemAmount;
    [SerializeField]
    private ItemScriptableObject Config;

    private Server _driveList;
    private GameObject server;
    private GameObject inventory;
    private GameObject hologramGameObject;
    private GameObject getActiveInventory;

    private GameObject currentInventorySlot;
    private string currentItem_Amount;
    private string currentItem_Name;
    private Sprite currentItem_Image;

    void Start()
    {
        server = GameObject.FindGameObjectWithTag("Server");
        _driveList = server.GetComponent<Server>();
        inventory = GameObject.FindGameObjectWithTag("inventoryUI");
        hologramGameObject = inventory.transform.Find("HologramBackground").gameObject;

    }

    public bool itemPickedup()
    {
        for (int i = 0; i < hologramGameObject.transform.childCount; i++)
        {
            if (hologramGameObject.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                getActiveInventory = hologramGameObject.transform.GetChild(i).gameObject;
                if (activeInventoryItem())
                {
                    _driveList.drives[i].generalData.Add(Config);
                    _driveList.drives[i].itemAmount.Add(itemAmount);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
        //First, try to put the item in the inventory that is currently active; if there is no active drive, then put it in the first available drive in the server.
    }

    public bool activeInventoryItem()
    {
        for (int x = 0; x < getActiveInventory.transform.childCount; x++) 
        {
            currentInventorySlot = getActiveInventory.transform.GetChild(x).gameObject;

            //if (currentInventorySlot.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text ==  Config.itemName)
            //{
            //    currentInventorySlot.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = (int.Parse(currentInventorySlot.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text) + itemAmount).ToString();
            //    break;
            //}

            if (currentInventorySlot.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text == "")
            {
                currentInventorySlot.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = itemAmount.ToString();
                currentInventorySlot.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = Config.itemName;
                currentInventorySlot.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().enabled = true;
                currentInventorySlot.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = Config.itemImage;

                return true;
            }
        }

        return false;
    }

    public void removeInventoryItem()
    {

    }

    public void inventoryFull()
    {
        Debug.Log("Inventory is full!");
    }
}
