using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

    public static InventoryManager Instance;
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
    }

    public ScriptableItem[] items;
    public Text[] itemsNames;

    public Image[] itemsImages;

    public InventorySlots[] itemSlots;

    public void AddItem(ScriptableItem item)
    {
        for(int i = 0; i < items.Length; i++)
        {
            if(items [i] == null)
            {
                items[i] = item;
                itemsNames[i].text = item.itemName;
                itemsImages[i].sprite = item.itemSprite;

                itemSlots[i].slotItem = item;
                itemSlots[i].slotNumber = i;

                return;
            }
        }
    }
}
