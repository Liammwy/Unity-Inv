using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour, IPickupable
{

    private Server _driveList;
    private GameObject server;
    public Items item;


    void Start()
    {
        item = gameObject.GetComponent<Items>();
        server = GameObject.FindGameObjectWithTag("Server");
        _driveList = server.GetComponent<Server>();
    }


    public void Pickup()
    {
        if (_driveList.drives.Count > 0)
        {
            if (item.itemPickedup())
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("inventory too full");
            }
        }
        else
        {
            Debug.Log("No drives available to pick iup ");
        }
    }
}
