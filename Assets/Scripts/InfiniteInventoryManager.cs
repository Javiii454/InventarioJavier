using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InfiniteInventoryManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static InfiniteInventoryManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        inventoryCanvasTransform = GameObject.Find("Inventory").transform;
    }

    public List<ScriptableItem> items;
    //public List<Text> itemsNames;

    //public List<Image> itemsImages;

    public List<InventorySlots> itemSlots;

    public GameObject slotPrefab;

    private Transform inventoryCanvasTransform;

    public void AddItem(ScriptableItem item)
    {

        GameObject prefab =  Instantiate(slotPrefab);

       prefab.transform.SetParent(inventoryCanvasTransform);

        InfiniteInventorySlots prefabScript = prefab.GetComponent<InfiniteInventorySlots>();

        prefabScript.slotItem = item;

       items.Add(item);





    }
}
