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

    public void itemPickedup()
    {
        for (int i = 0; i < hologramGameObject.transform.childCount; i++)
        {
            if (hologramGameObject.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                getActiveInventory = hologramGameObject.transform.GetChild(i).gameObject;
                activeInventoryItem();
                //Debug.Log(hologramGameObject.transform.GetChild(i).gameObject.transform.name);
                _driveList.drives[i].generalData.Add(Config);
                _driveList.drives[i].itemAmount.Add(itemAmount);
                break;
            }
        } 
        //First, try to put the item in the inventory that is currently active; if there is no active drive, then put it in the first available drive in the server.
    }

    public void activeInventoryItem()
    {
        for (int x = 0; x < getActiveInventory.transform.childCount; x++) 
        {
            currentInventorySlot = getActiveInventory.transform.GetChild(x).gameObject;
            currentItem_Amount = currentInventorySlot.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;
            currentItem_Name = currentInventorySlot.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text;
            currentItem_Image = currentInventorySlot.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite;

            if (currentItem_Name ==  Config.itemName)
            {
                currentItem_Amount = (int.Parse(currentItem_Amount + itemAmount).ToString();
                break;
            }

            if (currentItem_Name == "")
            {
                currentItem_Amount = itemAmount.ToString();
                currentItem_Name = Config.itemName;
                currentInventorySlot.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().enabled = true;
                currentItem_Image = Config.itemImage;

                break;
            }
        }
    }


    public void pick()
    {
        for (int i = 0; i < hologramGameObject.transform.childCount; i++)
        {
            if (hologramGameObject.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                _driveList.drives[i].generalData.Add(Config);
                _driveList.drives[i].itemAmount.Add(itemAmount);
                break;
            }
        }


        for (int x = 0; x < _driveList.drives.Count; x++)
        {
            Debug.Log(_driveList.drives[x].itemAmount);
        }


    }
}
