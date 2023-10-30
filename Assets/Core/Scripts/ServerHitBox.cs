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
        inputPrompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        in_zone = false;
        inputPrompt.SetActive(false);
    }
}
