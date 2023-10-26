using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ServerHitBox : MonoBehaviour
{
    public GameObject inputPrompt;
    public GameObject inputPromptError;
    public GameObject inventoryUi;
    public GameObject server;
    public GameObject driveInventoryBG;
    public GameObject driveInventoryGrid;
    private Server _driveList;
    public GameObject drivePrefab;


    public bool in_zone;

    
    private void Start()
    {
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
                driveInventoryBG.SetActive(true);
            }
            else if (_driveList.drives.Count <= 0)
            {

            }
        }     
    }

    private void OnTriggerExit(Collider other)
    {
        in_zone = false;
        driveInventoryBG.SetActive(false);
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
