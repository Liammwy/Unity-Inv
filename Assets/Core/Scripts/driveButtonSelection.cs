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

        Debug.Log(inventory.transform.childCount);
        uiPopup.SetActive(false);
        server.transform.Find(gameObject.name).gameObject.SetActive(true);
        inventory.transform.Find("HologramBackground").gameObject.SetActive(true);
        inventory.transform.Find("HologramBackground").transform.Find(gameObject.name).gameObject.SetActive(true);
        //Debug.Log(gameObject.name);
    }
}
