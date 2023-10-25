using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drives : MonoBehaviour
{
    [SerializeField]
    private int driveNumber;
    private HardDrivesScriptableObject Config;

    private void Start()
    {
        Debug.Log(driveNumber);
    }
}
