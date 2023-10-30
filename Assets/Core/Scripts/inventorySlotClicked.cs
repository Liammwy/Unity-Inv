using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UIElements;

public class inventorySlotClicked : MonoBehaviour
{

    private Sprite spriteName;
    private string itemAmount;
    private string itemName;

    public GameObject dirtPrefab;
    public GameObject stonePrefab;
    public void inventoryButtonClicked()
    {
        if (gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text != "")
        {
            GameObject newItem;
            spriteName = gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite;
            itemName = gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text.ToString();
            itemAmount = gameObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text;

            switch (itemName)
            {
                case "Stone":
                    newItem = Instantiate(stonePrefab);
                    newItem.GetComponent<Items>().itemAmount = int.Parse(itemAmount);
                    break;
                case "Dirt":
                    newItem = Instantiate(dirtPrefab);
                    newItem.GetComponent<Items>().itemAmount = int.Parse(itemAmount);
                    break;
            }

            gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = null;
            gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "";
            gameObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "";
            gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().enabled = false;

            Debug.Log(spriteName);
            Debug.Log(itemAmount);
            Debug.Log(itemName);
        }
        else
        {
            Debug.Log("There is no item in this position!");
        }
        // gameObject.name = the slot
    }
}
