using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driveButtonSelection : MonoBehaviour
{
    private GameObject server;
    private GameObject uiPopup;

    public void Start()
    {
        server = GameObject.FindGameObjectWithTag("Server");
        uiPopup = GameObject.FindGameObjectWithTag("driveUI");
    }

    public void driveClicked()
    {
        uiPopup.SetActive(false);
        server.transform.FindChild(gameObject.name).gameObject.SetActive(true);
        Debug.Log(gameObject.name);
    }
}
