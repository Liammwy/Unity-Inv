using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Drives", menuName = "Drives/Drives SO", order = 2)]
public class HardDrivesScriptableObject : ScriptableObject
{
    // Data that we want EVERY item to have
    public string driveName;
    public Sprite driveImage;
    public GameObject driveObject;
}
