using UnityEngine;
using UnityEngine.UI;
public class InfiniteInventorySlots : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public ScriptableItem slotItem;

    public int slotNumber;

    private Text itemNameText;

    private Image itemSprite;

    public GameObject inspectWindow;

    public Image inspectionImage;

    public Text inspectionName;

    public Text inspectionPrice;

    public Text inspectionDescription;

    public Button thisSlotButton;

    public Button deleteButton;

    public Button closeButton;


    void Awake()
    {
        itemNameText = GetComponentInChildren<Text>();
        itemSprite = GetComponentInChildren<Image>();

        GameObject canvas = GameObject.Find("Canvas");

        inspectWindow = canvas.transform.Find("InspectWindows").gameObject;

        inspectionImage = inspectWindow.transform.Find("Item Image").GetComponent<Image>();
        inspectionName = inspectWindow.transform.Find("Item Name").GetComponent<Text>();
        inspectionDescription = inspectWindow.transform.Find("Item Description").GetComponent<Text>();
        inspectionPrice = inspectWindow.transform.Find("Item Price").GetComponent<Text>(); 

        deleteButton = inspectWindow.transform.Find("DeleteButton").GetComponent<Button>();
        closeButton = inspectWindow.transform.Find("CloseButton").GetComponent<Button>();

        thisSlotButton = GetComponentInChildren<Button>();

        thisSlotButton.onClick.AddListener(InspectItem);
    }


    void Start()
    {

        itemNameText.text = slotItem.itemName;
       itemSprite.sprite = slotItem.itemSprite;


        
    }

    void InspectItem()
    {
        if(slotItem != null)
        {

            deleteButton.onClick.RemoveAllListeners();

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
        inspectWindow.SetActive(false);

        closeButton.onClick.RemoveListener(CloseWindow);
        
        deleteButton.onClick.RemoveListener(DeleteItem);
    }

    void DeleteItem()
    {
       InfiniteInventoryManager.Instance.items.Remove(slotItem);

       CloseWindow();

       Destroy(gameObject);

    }
}
