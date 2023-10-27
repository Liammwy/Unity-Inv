using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class driveButtonSelection : MonoBehaviour
{
    private GameObject server;
    private GameObject uiPopup;
    private GameObject inventory;

    private GameObject hologram;
    private GameObject driveLocation;

    public void Start()
    {
        server = GameObject.FindGameObjectWithTag("Server");
        uiPopup = GameObject.FindGameObjectWithTag("driveUI");
        inventory = GameObject.FindGameObjectWithTag("inventoryUI");
    }

    public void driveClicked()
    {
        hologram = inventory.transform.Find("HologramBackground").gameObject;
        // Checking to see if the hard drive they are trying to put into the server is already activated
        // If the drive is active, we want to remove it from the server
        if (inventory.transform.Find("HologramBackground").transform.Find(gameObject.name).gameObject.activeInHierarchy)
        {
            // Setting drive inside of server object to false
            server.transform.Find(gameObject.name).gameObject.SetActive(false);
            // Background of inventory hidden
            // The drive inventory associated with each drive
            inventory.transform.Find("HologramBackground").transform.Find(gameObject.name).gameObject.SetActive(false);

            for (int i = 0; i < inventory.transform.Find("HologramBackground").childCount; i++)
            {
                if (inventory.transform.Find("HologramBackground").GetChild(i).gameObject.name != gameObject.name
                    && (server.transform.Find(inventory.transform.Find("HologramBackground").GetChild(i).gameObject.name).gameObject.activeSelf))
                {
                    inventory.transform.Find("HologramBackground").GetChild(i).gameObject.SetActive(true);
                    break;
                }
            }

        }
        else
        {
            uiPopup.SetActive(false);
            server.transform.Find(gameObject.name).gameObject.SetActive(true);
            inventory.transform.Find("HologramBackground").gameObject.SetActive(true);

            for (int i = 0; i < inventory.transform.Find("HologramBackground").childCount; i++)
            {
                if (inventory.transform.Find("HologramBackground").GetChild(i).gameObject.activeInHierarchy)
                {
                    inventory.transform.Find("HologramBackground").GetChild(i).gameObject.SetActive(false);
                }
            }

            inventory.transform.Find("HologramBackground").transform.Find(gameObject.name).gameObject.SetActive(true);
        }
    }
}
