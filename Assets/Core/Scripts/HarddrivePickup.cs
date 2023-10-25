using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardDrivePickup : MonoBehaviour, IPickupable
{
    public bool hasDrive = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pickup()
    {
        Debug.Log("Picked up drive");
        hasDrive = true;
        gameObject.SetActive(false);
    }
}
