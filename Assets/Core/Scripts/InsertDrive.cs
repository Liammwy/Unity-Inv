using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertDrive : MonoBehaviour
{
    public GameObject serverHitBox;
    public GameObject hardDriveItem;

    public GameObject inventoryUI;
    public GameObject InputPrompt;

    private HardDrivePickup _drivePickup;
    private ServerHitBox _serverHitBox;

    private void Start()
    {
        _drivePickup = hardDriveItem.GetComponent<HardDrivePickup>();
        _serverHitBox = serverHitBox.GetComponent<ServerHitBox>();
    }

    public void insertDrive()
    {
        Debug.Log("Running");
        if (_serverHitBox.in_zone && _drivePickup.hasDrive)
        {
            if (!inventoryUI.activeSelf)
            {
                inventoryUI.SetActive(true);
                InputPrompt.SetActive(false);
            }
            else
            {
                inventoryUI.SetActive(false);
            }
        }
    }
}
