using System;
using UnityEngine;

public enum ItemType // 実装するItemの種類
    {
        ConsumptionItem,
        MaterialItem,
        WeaponItem,
        ArmorItem,
        FoodItem,
        KeyItem,
    }

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CreateItem")]
public class ItemSourceData : ScriptableObject
{
    [SerializeField] private string _id;
    public string id
    {
        get { return _id; }
    }

    [SerializeField] private string _itemName;
    public string itemName
    {
        get { return _itemName; }
    }

    [SerializeField] private ItemType _itemType;
    public ItemType itemType
    {
        get { return _itemType; }
    }

    [SerializeField] private Sprite _icon;
    public Sprite icon 
    {
        get { return _icon; }
    }

    [SerializeField] private int _buyingPrice;
    public int buyingPrice
    {
        get { return _buyingPrice; }
    }

    [SerializeField] private int _sellingPrice;
    public int sellingPrice
    {
        get { return _sellingPrice; }
    }

    [TextArea] private String _infomation;
    public String infomation
    {
        get { return _infomation; }
    }


    public void Interact()
    {
        InteractItem();
    }

    public void InteractItem()
    {
        Debug.Log("Item is picked up.");
        //アイテム取得処理
        //gameObject.SetActive(false);
        //this.Destroy(gameObject);
        // 他の処理をここに追加（例：インベントリにアイテムを追加する等）
    }
}