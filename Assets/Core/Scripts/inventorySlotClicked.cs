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
    public GameObject woodPrefab;
    private GameObject playerCharacter;

    public void Start()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("Player");
    }
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
                    newItem = Instantiate(stonePrefab, new Vector3(playerCharacter.transform.position.x, playerCharacter.transform.position.y + 0.2f, playerCharacter.transform.position.z + Random.Range(0.5f, 1.5f)), Quaternion.identity);
                    newItem.name = "Stone";
                    newItem.GetComponent<Items>().itemAmount = int.Parse(itemAmount);
                    //newItem.transform.position.x = playerCharacter.transform.position.x;
                    break;
                case "Dirt":
                    newItem = Instantiate(dirtPrefab, new Vector3(playerCharacter.transform.position.x, playerCharacter.transform.position.y + 0.2f, playerCharacter.transform.position.z + Random.Range(0.5f, 1.5f)), Quaternion.identity);
                    newItem.name = "Dirt";
                    newItem.GetComponent<Items>().itemAmount = int.Parse(itemAmount);
                    break;
                case "Wood":
                    newItem = Instantiate(woodPrefab, new Vector3(playerCharacter.transform.position.x, playerCharacter.transform.position.y + 0.2f, playerCharacter.transform.position.z + Random.Range(0.5f, 1.5f)), Quaternion.identity);
                    newItem.name = "Wood";
                    newItem.GetComponent<Items>().itemAmount = int.Parse(itemAmount);
                    break;
            }

            gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().sprite = null;
            gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "";
            gameObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = "";
            gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().enabled = false;
        }
    }
}
