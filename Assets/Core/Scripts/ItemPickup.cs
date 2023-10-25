using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour, IPickupable
{

    public bool hasServer = false;
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
        Debug.Log("Picked up the server!");
        hasServer = true;
        Debug.Log(hasServer);
        Destroy(gameObject);
    }
}
