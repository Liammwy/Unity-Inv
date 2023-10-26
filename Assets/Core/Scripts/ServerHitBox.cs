using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.InputSystem;

public class ServerHitBox : MonoBehaviour
{
    public GameObject inputPrompt;
    public GameObject inputPromptError;
    public GameObject inventoryUi;
    public GameObject server;
    private Server _driveList;

    public bool in_zone;

    private HardDrivePickup hardDrivePickup;
    
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
                inputPrompt.SetActive(true);
            }
            else if (_driveList.drives.Count <= 0)
            {
                inputPromptError.SetActive(true);
            }
        }     
    }

    private void OnTriggerExit(Collider other)
    {
        in_zone = false;
        inputPrompt.SetActive(false);
        inputPromptError.SetActive(false);
    }
}
