using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertDrive : MonoBehaviour
{
    public GameObject server;
    public GameObject serverHitBox;

    public GameObject inventoryUI;
    public GameObject InputPrompt;

    private ServerHitBox _serverHitBox;
    private Server _driveList;

    private List<int> _drivesInServer = new List<int>();

    private void Start()
    {
        _serverHitBox = serverHitBox.GetComponent<ServerHitBox>();
        _driveList = server.GetComponent<Server>();
    }

    public void insertDrive()
    {
        Debug.Log("Running");
        if (_serverHitBox.in_zone && _driveList.drives.Count > 0)
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



    // Will run when the player presses the key to insert a drive into the server
    public void function()
    {
        // If the player is within the servers zone and they have picked up a drive
        if (_serverHitBox.in_zone && _driveList.drives.Count > 0) 
        {
        }

    }

}
