using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun" , menuName ="Scriptable Object/Gun")]
public class GunScriptableObject : ScriptableObject
{
    [SerializeField] private GunStats _stats;
    public GunStats BaseStats => _stats;
    public GunType GunType;
    public GunSlot GunSlot;
    public GunBase Prefab;
}

[Serializable]
public struct GunStats
{
    public float damage;
    public float shootRate;
    public float reloadTime;
    public int maxAmmo;
    public int tapeAmmo;
    public float verticalRecoil;
}

//[Serializable]
//public enum GunID
//{
//    Pistol = 0,
//    SMG = 1,
//    Rifle = 2,
//    Sniper = 3,
//    Shotgun = 4,
//    None = 5,
//}

[Serializable]
public enum GunType
{
    None = 0,
    SMG = 1,
    Rifle = 2,
    Sniper = 3,
    Shotgun = 4,
    Pistol = 5,
}

[Serializable]

public enum GunSlot
{
    MainGun = 0 ,
    SubGun = 1,
    SpecialGun = 2,
    None = 3,
}
