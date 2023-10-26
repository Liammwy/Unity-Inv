using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForDrives : MonoBehaviour
{
    private List<string> drives = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //When player is close to the server hitbox, display a UI based on if they have an available drive in their inventory or not.
    //If they have an available drive in their inventory, we want them to be able to press "E" to insert that drive into the server.
    //If the server is full of drives, display another message saying that there's no available slots.

    //Want the drives to be labelled based on how many are loaded into the world. For example, the first drive is "drive1" then "drive2" etc.
    //Each drive has to have a separate inventory system that can be displayed when put into the server.
    //Always display the drive's inventory that is at the top of the server (so, if drive3 is at the top, we will display that).
    //When removing drives from the server, we want to always remove the one from the top most slot first; then the second most slot.

    //If there's no drives in the first slot, but drives in the second slot, then we want to display that inventory
    //Max of 4 drives



    public void onDrivePickup()
    {

    }
}
