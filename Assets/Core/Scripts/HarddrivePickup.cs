using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardDrivePickup : MonoBehaviour, IPickupable
{

    private GameObject server;
    private Server _driveList;



    void Start()
    {
        server = GameObject.FindGameObjectWithTag("Server");
        _driveList = server.GetComponent<Server>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pickup()
    {
        if (_driveList.drives.Count < 4) 
        {
            _driveList.drives.Add(new Drive());
            _driveList.drives[_driveList.drives.Count - 1].itemAmount.Add(20);

            Debug.Log(_driveList.drives.Count);
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Too many drives!");
        }
    }

    public void createDriveInventory()
    {

    }
}
