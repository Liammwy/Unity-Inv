using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardDrivePickup : MonoBehaviour, IPickupable
{

    private GameObject server;
    private Server _driveList;
    private GameObject inventoryList;
    public GameObject buttonDrivePrefab;
    public GameObject inventoryOfDrivePrefab;


    void Start()
    {
        inventoryList = GameObject.FindGameObjectWithTag("inventoryUI");
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

            GameObject newObject = Instantiate(buttonDrivePrefab, inventoryList.transform.Find("Drives").Find("InventoryGrid").gameObject.transform);
            newObject.name = "Drive" + (inventoryList.transform.Find("Drives").Find("InventoryGrid").gameObject.transform.childCount).ToString();

            GameObject newDriveInventory = Instantiate(inventoryOfDrivePrefab, inventoryList.transform.Find("HologramBackground").gameObject.transform);
            newDriveInventory.name = "Drive" + (inventoryList.transform.Find("Drives").Find("InventoryGrid").gameObject.transform.childCount).ToString();
            newDriveInventory.SetActive(false);

            //Debug.Log(_driveList.drives.Count);
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
