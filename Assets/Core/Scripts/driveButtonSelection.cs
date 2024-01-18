using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class driveButtonSelection : MonoBehaviour
{
    private GameObject server;
    private GameObject uiPopup;
    private GameObject inventory;

    private GameObject hologramGameObject;
    private GameObject hologramBackground;
    public Material server_Active;
    public Material server_Inactive;
    

    public void Start()
    {
        server = GameObject.FindGameObjectWithTag("Server");
        uiPopup = GameObject.FindGameObjectWithTag("driveUI");
        inventory = GameObject.FindGameObjectWithTag("inventoryUI");
    }

    public void driveClicked()
    {
        hologramGameObject = inventory.transform.Find("HologramBackground").gameObject;
        // Checking to see if the hard drive they are trying to put into the server is already activated
        // If the drive is active, we want to remove it from the server
        if (hologramGameObject.transform.Find(gameObject.name).gameObject.activeInHierarchy)
        {
            // Setting drive inside of server object to false
            server.transform.Find(gameObject.name).gameObject.SetActive(false);
            // Background of inventory hidden
            // The drive inventory associated with each drive
            hologramGameObject.transform.Find(gameObject.name).gameObject.SetActive(false);
            hologramGameObject.SetActive(false);

            for (int i = 0; i < hologramGameObject.transform.childCount; i++)
            {
                if (hologramGameObject.transform.GetChild(i).gameObject.name != gameObject.name
                    && (server.transform.Find(hologramGameObject.transform.GetChild(i).gameObject.name).gameObject.activeSelf))
                {
                    server.transform.Find(hologramGameObject.transform.GetChild(i).gameObject.name).gameObject.GetComponent<MeshRenderer>().material = server_Active;
                    hologramGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    break;
                }
            }

        }
        else
        {
            uiPopup.SetActive(false);
            server.transform.Find(gameObject.name).gameObject.SetActive(true);
            hologramGameObject.SetActive(true);

            for (int i = 0; i < hologramGameObject.transform.childCount; i++)
            {
                if (hologramGameObject.transform.GetChild(i).gameObject.activeInHierarchy)
                {
                    server.transform.Find(hologramGameObject.transform.GetChild(i).gameObject.name).gameObject.GetComponent<MeshRenderer>().material = server_Inactive;
                    hologramGameObject.transform.GetChild(i).gameObject.SetActive(false);
                }
            }

            hologramGameObject.transform.Find(gameObject.name).gameObject.SetActive(true);
            server.transform.Find(gameObject.name).gameObject.GetComponent<MeshRenderer>().material = server_Active;

        }
    }
}
