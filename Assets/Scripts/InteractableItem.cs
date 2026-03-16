using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public ScriptableItem item;

    public SpriteRenderer spriteRenderer;
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Start()
    {
        spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        InventoryManager.Instance.AddItem(item);
        Destroy(gameObject);
    }
}
