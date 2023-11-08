using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceSystem : Singleton<ResourceSystem>
{
    [Header("Gun Resources")]
    [SerializeField] private List<GunScriptableObject> guns;
    public List<GunScriptableObject> Guns => guns;
    private Dictionary<GunType, GunScriptableObject> GunsDict;

    [Header("Bullet Impact Resources")]
    [SerializeField] private List<BulletImpactScriptableObject> bulletImpacts;
    public List<BulletImpactScriptableObject> BulletImpacts => bulletImpacts;
    private Dictionary<BulletImpactType, BulletImpactScriptableObject> BulletImpactDict;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        AssembleResources();
    }

    private void AssembleResources()
    {
        LoadGuns();
        LoadBulletImpacts();
    }

    private void LoadBulletImpacts()
    {
        bulletImpacts = Resources.LoadAll<BulletImpactScriptableObject>("BulletImpacts").ToList();
        BulletImpactDict = bulletImpacts.ToDictionary(r => r.BulletImpactType, r => r);
    }

    private void LoadGuns()
    {
        guns = Resources.LoadAll<GunScriptableObject>("Guns").ToList();
        GunsDict = guns.ToDictionary(r => r.GunType, r => r);
    }

    public GunScriptableObject GetGun(GunType n) => GunsDict[n];
    public BulletImpactScriptableObject GetBulletImpact(BulletImpactType t) => BulletImpactDict[t];
}
