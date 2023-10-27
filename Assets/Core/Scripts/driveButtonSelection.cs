using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driveButtonSelection : MonoBehaviour
{
    private GameObject server;
    private GameObject uiPopup;
    private GameObject inventory;

    public void Start()
    {
        server = GameObject.FindGameObjectWithTag("Server");
        uiPopup = GameObject.FindGameObjectWithTag("driveUI");
        inventory = GameObject.FindGameObjectWithTag("inventoryUI");
    }

    public void driveClicked()
    {
        uiPopup.SetActive(false);
        server.transform.Find(gameObject.name).gameObject.SetActive(true);

        inventory.transform.Find("HologramBackground").gameObject.SetActive(true);

        for (int i = 0; i < inventory.transform.Find("HologramBackground").childCount; i++) 
        {
            if (inventory.transform.Find("HologramBackground").GetChild(i).gameObject.activeInHierarchy)
            {
                Debug.Log(inventory.transform.Find("HologramBackground").GetChild(i).gameObject.name);
                inventory.transform.Find("HologramBackground").GetChild(i).gameObject.SetActive(false);
            }
        }

        inventory.transform.Find("HologramBackground").transform.Find(gameObject.name).gameObject.SetActive(true);
        //Debug.Log(gameObject.name);
    }

    public void driveRemoved()
    {
        inventory.transform.Find("HologramBackground").transform.Find(gameObject.name).gameObject.SetActive(false);
    }
}
