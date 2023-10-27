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
    private Server _driveList;

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
                inventoryUi.SetActive(true);
            }
        }     
    }

    private void OnTriggerExit(Collider other)
    {
        in_zone = false;
        inventoryUi.SetActive(false);
    }
}
