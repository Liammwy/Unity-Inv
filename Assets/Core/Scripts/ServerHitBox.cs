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
    public GameObject hard_drive_item;
    public bool in_zone;

    private HardDrivePickup hardDrivePickup;
    
    private void Start()
    {
        hardDrivePickup = hard_drive_item.GetComponent<HardDrivePickup>();
    }

    private void OnTriggerEnter(Collider other)
    {
        in_zone = true;
        if (!inventoryUi.activeInHierarchy)
        {
            if (hardDrivePickup.hasDrive)
            {
                inputPrompt.SetActive(true);
            }
            else if (!hardDrivePickup.hasDrive)
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
