using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour, IPickupable
{

    public void Pickup()
    {
        Destroy(gameObject);
    }
}
