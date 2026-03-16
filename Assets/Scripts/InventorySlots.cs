using UnityEngine;
using UnityEngine.UI;

public class InventorySlots : MonoBehaviour
{

    public ScriptableItem slotItem;

    public int slotNumber;

    public GameObject inspectWindow;

    public Image inspectionImage;

    public Text inspectionName;

    public Text inspectionPrice;

    public Text inspectionDescription;

    public Button thisSlotButton;

    public Button deleteButton;

    public Button closeButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisSlotButton = GetComponentInChildren<Button>();
        thisSlotButton.onClick.AddListener(InspectItem);
    }

    void InspectItem()
    {
        if(slotItem != null)
        {
            closeButton.onClick.AddListener(CloseWindow);

            deleteButton.onClick.AddListener(DeleteItem);

            inspectionImage.sprite = slotItem.itemSprite;

            inspectionName.text = slotItem.itemName;

            inspectionPrice.text = slotItem.itemSellPrice.ToString();
            
            inspectionDescription.text = slotItem.itemDescription;

            inspectWindow.SetActive(true);
        }
        
    }

    void CloseWindow()
    {

    }

    void DeleteItem()
    {

    }

}
