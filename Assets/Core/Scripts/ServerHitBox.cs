using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ServerHitBox : MonoBehaviour
{
    public GameObject inventoryUi;
    private GameObject server;
    public GameObject driveInventoryGrid;
    private Server _driveList;

    public GameObject drivePrefab;


    public bool in_zone;

    
    private void Start()
    {
        server = GameObject.FindGameObjectWithTag("Server");
        _driveList = server.GetComponent<Server>();
    }

    private void OnTriggerEnter(Collider other)
    {
        in_zone = true;
        if (!inventoryUi.activeInHierarchy)
        {
            if (_driveList.drives.Count > 0)
            {
                driveInventoryUI();
                inventoryUi.SetActive(true);
            }
        }     
    }

    private void OnTriggerExit(Collider other)
    {
        in_zone = false;
        inventoryUi.SetActive(false);
    }

    public void driveInventoryUI()
    {
        for (int i = 1; i <= _driveList.drives.Count - driveInventoryGrid.gameObject.transform.childCount; i++)
        {
            GameObject newObject = Instantiate(drivePrefab, driveInventoryGrid.gameObject.transform);
            newObject.name = "Drive" + (driveInventoryGrid.gameObject.transform.childCount).ToString();
        }
    }
}
