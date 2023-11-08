using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory
{
    private Dictionary<GunSlot, KeyValuePair<GunType,GunBase>> _itemList = new();
    public Dictionary<GunSlot, KeyValuePair<GunType, GunBase>> ItemList => _itemList;

    private List<GunSlot> _gunSlots = new List<GunSlot>
    {
        GunSlot.MainGun,
        GunSlot.SubGun,
        GunSlot.SpecialGun,
    };

    public PlayerInventory()
    {
        _itemList.Clear();
        var gunPlaceHolder = new KeyValuePair<GunType, GunBase>(GunType.None, null);
        foreach (var gunSlot in _gunSlots)
        {
            _itemList.Add(gunSlot , gunPlaceHolder);
        }
    }

    public KeyValuePair<GunType, GunBase> GetItem(GunSlot gunSlot)
    {
        return _itemList[gunSlot];
    }

    public void UpdateItem(GunSlot gunSlot , KeyValuePair<GunType, GunBase> item)
    {
        _itemList[gunSlot] = item;
    }

    public void DeactivateAllItems()
    {
        foreach (var item in _itemList)
        {
            if (item.Value.Value != null)
            {
                item.Value.Value.gameObject.SetActive(false);
            }  
        }
    }
}

//[Serializable]
//public enum ItemType
//{
//    MainGun,
//    SubGun,
//    SpecialGun,
//    Grenade, 
//    Armor
//}

//public enum GrenadeType
//{
//    Frag,
//    Flash,
//    Smoke
//}
